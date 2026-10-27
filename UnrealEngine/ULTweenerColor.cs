using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002240 RID: 8768
	[UnrealObjectPath("/Script/LTween.LTweenerColor")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class ULTweenerColor : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602161C RID: 136732 RVA: 0x00313011 File Offset: 0x00311211
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerColor._ClassPtr;
		}

		// Token: 0x0602161D RID: 136733 RVA: 0x00313020 File Offset: 0x00311220
		public ULTweenerColor() : this(BuiltinUtils.AllocNativeUObject(ULTweenerColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602161E RID: 136734 RVA: 0x00313048 File Offset: 0x00311248
		[NullableContext(1)]
		public ULTweenerColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602161F RID: 136735 RVA: 0x0031307B File Offset: 0x0031127B
		static ULTweenerColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerColor");
		}

		// Token: 0x06021620 RID: 136736 RVA: 0x00313089 File Offset: 0x00311289
		protected ULTweenerColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CA5 RID: 72869
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerColor";

		// Token: 0x04011CA6 RID: 72870
		private static IntPtr _ClassPtr;

		// Token: 0x04011CA7 RID: 72871
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
