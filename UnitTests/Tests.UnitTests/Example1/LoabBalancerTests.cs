﻿using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Example1;

namespace Tests.UnitTests.Example1;

public class LoabBalancerTests
{
    private readonly LoadBalancer _loadBalancer;

    //setup
    public LoabBalancerTests()
    {
            _loadBalancer = new LoadBalancer(["conn1", "conn2", "conn3"]);
    }
    [Fact] 
    public void MoveNext_ShouldRotateThroughConnections()
    {

        //act
        var tenent1 = _loadBalancer.MoveNext();
        var tenent2 = _loadBalancer.MoveNext();
        var tenent3 = _loadBalancer.MoveNext();
        var tenent4 = _loadBalancer.MoveNext();

        //assert
        tenent1.ConnectionString.Should().Be("conn1");
        tenent1.Id.Should().Be(1);
        tenent1.Predicate.Should().Be('a');

        tenent2.ConnectionString.Should().Be("conn2");
        tenent2.Id.Should().Be(2);
        tenent2.Predicate.Should().Be('b');

        tenent3.ConnectionString.Should().Be("conn3");
        tenent3.Id.Should().Be(3);
        tenent3.Predicate.Should().Be('c');

        tenent4.ConnectionString.Should().Be("conn1");
        tenent4.Id.Should().Be(1);
        tenent4.Predicate.Should().Be('a');

    }

    [Fact]
    public void GetConnectionStringByPredicateId_ShouldReturnCorrectConnectionString()
    {
        //act
        var conn1 = _loadBalancer.GetConnectionStringByPredicateId('a');
        var conn2 = _loadBalancer.GetConnectionStringByPredicateId('b');
        var conn3 = _loadBalancer.GetConnectionStringByPredicateId('c');

        //assert
        conn1.Should().Be("conn1");
        conn2.Should().Be("conn2");
        conn3.Should().Be("conn3");
    }
}