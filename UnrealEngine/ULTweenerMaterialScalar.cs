using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002246 RID: 8774
	[UnrealObjectPath("/Script/LTween.LTweenerMaterialScalar")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class ULTweenerMaterialScalar : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602163E RID: 136766 RVA: 0x0031339A File Offset: 0x0031159A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerMaterialScalar._ClassPtr;
		}

		// Token: 0x0602163F RID: 136767 RVA: 0x003133A8 File Offset: 0x003115A8
		public ULTweenerMaterialScalar() : this(BuiltinUtils.AllocNativeUObject(ULTweenerMaterialScalar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021640 RID: 136768 RVA: 0x003133D0 File Offset: 0x003115D0
		[NullableContext(1)]
		public ULTweenerMaterialScalar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerMaterialScalar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021641 RID: 136769 RVA: 0x00313403 File Offset: 0x00311603
		static ULTweenerMaterialScalar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerMaterialScalar");
		}

		// Token: 0x06021642 RID: 136770 RVA: 0x00313411 File Offset: 0x00311611
		protected ULTweenerMaterialScalar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CB7 RID: 72887
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerMaterialScalar";

		// Token: 0x04011CB8 RID: 72888
		private static IntPtr _ClassPtr;

		// Token: 0x04011CB9 RID: 72889
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
