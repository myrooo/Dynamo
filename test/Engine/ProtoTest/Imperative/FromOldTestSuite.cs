using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.Imperative
{
    [TestFixture]
    class FromOldTestSuite : ProtoTestBase
    {
        [Test]
        public void TestConds01()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("f0", false);
            thisTest.Verify("f1", false);
            thisTest.Verify("f2", false);
            thisTest.Verify("f3", false);
            thisTest.Verify("t0", true);
            thisTest.Verify("t1", true);
            thisTest.Verify("t2", true);
            thisTest.Verify("t3", true);
            thisTest.Verify("t4", true);
            thisTest.Verify("t5", true);
            thisTest.Verify("t6", true);
            thisTest.Verify("t7", true);
        }

        [Test]
        public void TestConds02()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("f0", false);
            thisTest.Verify("f1", false);
            thisTest.Verify("f2", false);
            thisTest.Verify("f3", false);
            thisTest.Verify("t0", true);
            thisTest.Verify("t1", true);
            thisTest.Verify("t2", true);
            thisTest.Verify("t3", true);
            thisTest.Verify("t4", true);
            thisTest.Verify("t5", true);
            thisTest.Verify("t6", true);
            thisTest.Verify("t7", true);
        }

        [Test]
        public void TestConds03()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("f0", false);
            thisTest.Verify("f1", false);
            thisTest.Verify("f2", false);
            thisTest.Verify("f3", false);
            thisTest.Verify("t0", true);
            thisTest.Verify("t1", true);
            thisTest.Verify("t2", true);
            thisTest.Verify("t3", true);
            thisTest.Verify("t4", true);
            thisTest.Verify("t5", true);
            thisTest.Verify("t6", true);
            thisTest.Verify("t7", true);
        }

        [Test]
        public void FuncWithDec()
        {
            String code =
@"y;[Imperative]
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 57);
        }


    }
}