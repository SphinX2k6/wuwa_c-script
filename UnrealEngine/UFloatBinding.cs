using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002968 RID: 10600
	[UnrealObjectPath("/Script/UMG.FloatBinding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UFloatBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602737A RID: 160634 RVA: 0x003BC9E4 File Offset: 0x003BABE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFloatBinding._ClassPtr;
		}

		// Token: 0x0602737B RID: 160635 RVA: 0x003BC9F0 File Offset: 0x003BABF0
		public UFloatBinding() : this(BuiltinUtils.AllocNativeUObject(UFloatBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602737C RID: 160636 RVA: 0x003BCA18 File Offset: 0x003BAC18
		[NullableContext(1)]
		public UFloatBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFloatBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602737D RID: 160637 RVA: 0x003BCA4B File Offset: 0x003BAC4B
		public float GetValue()
		{
			return UFloatBinding.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x0602737E RID: 160638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x0602737F RID: 160639 RVA: 0x003BCA58 File Offset: 0x003BAC58
		static UFloatBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.FloatBinding");
		}

		// Token: 0x06027380 RID: 160640 RVA: 0x003BCA66 File Offset: 0x003BAC66
		protected UFloatBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158EA RID: 88298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.FloatBinding";

		// Token: 0x040158EB RID: 88299
		private static IntPtr _ClassPtr;

		// Token: 0x040158EC RID: 88300
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
