using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002248 RID: 8776
	[UnrealObjectPath("/Script/LTween.LTweenerPosition")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class ULTweenerPosition : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021648 RID: 136776 RVA: 0x0031349A File Offset: 0x0031169A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerPosition._ClassPtr;
		}

		// Token: 0x06021649 RID: 136777 RVA: 0x003134A8 File Offset: 0x003116A8
		public ULTweenerPosition() : this(BuiltinUtils.AllocNativeUObject(ULTweenerPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602164A RID: 136778 RVA: 0x003134D0 File Offset: 0x003116D0
		[NullableContext(1)]
		public ULTweenerPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602164B RID: 136779 RVA: 0x00313503 File Offset: 0x00311703
		static ULTweenerPosition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerPosition");
		}

		// Token: 0x0602164C RID: 136780 RVA: 0x00313511 File Offset: 0x00311711
		protected ULTweenerPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CBD RID: 72893
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerPosition";

		// Token: 0x04011CBE RID: 72894
		private static IntPtr _ClassPtr;

		// Token: 0x04011CBF RID: 72895
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
