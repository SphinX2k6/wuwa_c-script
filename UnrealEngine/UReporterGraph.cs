using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200108A RID: 4234
	[UnrealObjectPath("/Script/Engine.ReporterGraph")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UReporterGraph : UReporterBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F1F9 RID: 61945 RVA: 0x00167105 File Offset: 0x00165305
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReporterGraph._ClassPtr;
		}

		// Token: 0x0600F1FA RID: 61946 RVA: 0x00167114 File Offset: 0x00165314
		public UReporterGraph() : this(BuiltinUtils.AllocNativeUObject(UReporterGraph.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F1FB RID: 61947 RVA: 0x0016713C File Offset: 0x0016533C
		[NullableContext(1)]
		public UReporterGraph(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReporterGraph.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F1FC RID: 61948 RVA: 0x0016716F File Offset: 0x0016536F
		static UReporterGraph()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReporterGraph");
		}

		// Token: 0x0600F1FD RID: 61949 RVA: 0x0016717D File Offset: 0x0016537D
		protected UReporterGraph(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008334 RID: 33588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReporterGraph";

		// Token: 0x04008335 RID: 33589
		private static IntPtr _ClassPtr;

		// Token: 0x04008336 RID: 33590
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
