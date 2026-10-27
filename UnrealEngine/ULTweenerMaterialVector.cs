using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002247 RID: 8775
	[UnrealObjectPath("/Script/LTween.LTweenerMaterialVector")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class ULTweenerMaterialVector : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021643 RID: 136771 RVA: 0x0031341A File Offset: 0x0031161A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerMaterialVector._ClassPtr;
		}

		// Token: 0x06021644 RID: 136772 RVA: 0x00313428 File Offset: 0x00311628
		public ULTweenerMaterialVector() : this(BuiltinUtils.AllocNativeUObject(ULTweenerMaterialVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021645 RID: 136773 RVA: 0x00313450 File Offset: 0x00311650
		[NullableContext(1)]
		public ULTweenerMaterialVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerMaterialVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021646 RID: 136774 RVA: 0x00313483 File Offset: 0x00311683
		static ULTweenerMaterialVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerMaterialVector");
		}

		// Token: 0x06021647 RID: 136775 RVA: 0x00313491 File Offset: 0x00311691
		protected ULTweenerMaterialVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CBA RID: 72890
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerMaterialVector";

		// Token: 0x04011CBB RID: 72891
		private static IntPtr _ClassPtr;

		// Token: 0x04011CBC RID: 72892
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
