using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD4 RID: 6868
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroControlTodTime")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroControlTodTime : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019949 RID: 104777 RVA: 0x0025D1B8 File Offset: 0x0025B3B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroControlTodTime._ClassPtr;
		}

		// Token: 0x0601994A RID: 104778 RVA: 0x0025D1C4 File Offset: 0x0025B3C4
		public AKuroControlTodTime() : this(BuiltinUtils.AllocNativeUObject(AKuroControlTodTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601994B RID: 104779 RVA: 0x0025D1EC File Offset: 0x0025B3EC
		[NullableContext(1)]
		public AKuroControlTodTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroControlTodTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601994C RID: 104780 RVA: 0x0025D21F File Offset: 0x0025B41F
		public virtual void DoUpdate(float DeltaTime)
		{
			AKuroControlTodTime.__DoUpdate_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601994D RID: 104781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoUpdate_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601994E RID: 104782 RVA: 0x0025D22D File Offset: 0x0025B42D
		static AKuroControlTodTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroControlTodTime");
		}

		// Token: 0x0601994F RID: 104783 RVA: 0x0025D23B File Offset: 0x0025B43B
		protected AKuroControlTodTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DED0 RID: 57040
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroControlTodTime";

		// Token: 0x0400DED1 RID: 57041
		private static IntPtr _ClassPtr;

		// Token: 0x0400DED2 RID: 57042
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02003137 RID: 12599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DoUpdate_FunctionParams
		{
			// Token: 0x04016F47 RID: 94023
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
