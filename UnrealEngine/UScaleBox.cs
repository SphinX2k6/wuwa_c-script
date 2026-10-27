using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029CE RID: 10702
	[UnrealObjectPath("/Script/UMG.ScaleBox")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class UScaleBox : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027901 RID: 162049 RVA: 0x003C5C2F File Offset: 0x003C3E2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScaleBox._ClassPtr;
		}

		// Token: 0x06027902 RID: 162050 RVA: 0x003C5C3C File Offset: 0x003C3E3C
		public UScaleBox() : this(BuiltinUtils.AllocNativeUObject(UScaleBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027903 RID: 162051 RVA: 0x003C5C64 File Offset: 0x003C3E64
		[NullableContext(1)]
		public UScaleBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScaleBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700979A RID: 38810
		// (get) Token: 0x06027904 RID: 162052 RVA: 0x003C5C97 File Offset: 0x003C3E97
		// (set) Token: 0x06027905 RID: 162053 RVA: 0x003C5CAB File Offset: 0x003C3EAB
		public unsafe TEnumAsByte<EStretch> Stretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_Stretch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_Stretch) = value;
			}
		}

		// Token: 0x1700979B RID: 38811
		// (get) Token: 0x06027906 RID: 162054 RVA: 0x003C5CC0 File Offset: 0x003C3EC0
		// (set) Token: 0x06027907 RID: 162055 RVA: 0x003C5CD4 File Offset: 0x003C3ED4
		public unsafe TEnumAsByte<EStretchDirection> StretchDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_StretchDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_StretchDirection) = value;
			}
		}

		// Token: 0x1700979C RID: 38812
		// (get) Token: 0x06027908 RID: 162056 RVA: 0x003C5CE9 File Offset: 0x003C3EE9
		// (set) Token: 0x06027909 RID: 162057 RVA: 0x003C5CF9 File Offset: 0x003C3EF9
		public unsafe float UserSpecifiedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_UserSpecifiedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_UserSpecifiedScale) = value;
			}
		}

		// Token: 0x1700979D RID: 38813
		// (get) Token: 0x0602790A RID: 162058 RVA: 0x003C5D0A File Offset: 0x003C3F0A
		// (set) Token: 0x0602790B RID: 162059 RVA: 0x003C5D1A File Offset: 0x003C3F1A
		public unsafe bool IgnoreInheritedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_IgnoreInheritedScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBox.__PropertyOffset_IgnoreInheritedScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602790C RID: 162060 RVA: 0x003C5D2B File Offset: 0x003C3F2B
		public void SetUserSpecifiedScale(float InUserSpecifiedScale)
		{
			UScaleBox.__SetUserSpecifiedScale_Internal(base.NativePtr, InUserSpecifiedScale);
		}

		// Token: 0x0602790D RID: 162061 RVA: 0x003C5D39 File Offset: 0x003C3F39
		public void SetStretchDirection(EStretchDirection InStretchDirection)
		{
			UScaleBox.__SetStretchDirection_Internal(base.NativePtr, InStretchDirection);
		}

		// Token: 0x0602790E RID: 162062 RVA: 0x003C5D4C File Offset: 0x003C3F4C
		public void SetStretch(EStretch InStretch)
		{
			UScaleBox.__SetStretch_Internal(base.NativePtr, InStretch);
		}

		// Token: 0x0602790F RID: 162063 RVA: 0x003C5D5F File Offset: 0x003C3F5F
		public void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
		{
			UScaleBox.__SetIgnoreInheritedScale_Internal(base.NativePtr, bInIgnoreInheritedScale);
		}

		// Token: 0x06027910 RID: 162064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserSpecifiedScale_Internal(IntPtr @this, float InUserSpecifiedScale);

		// Token: 0x06027911 RID: 162065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchDirection_Internal(IntPtr @this, TEnumAsByte<EStretchDirection> InStretchDirection);

		// Token: 0x06027912 RID: 162066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretch_Internal(IntPtr @this, TEnumAsByte<EStretch> InStretch);

		// Token: 0x06027913 RID: 162067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreInheritedScale_Internal(IntPtr @this, bool bInIgnoreInheritedScale);

		// Token: 0x06027914 RID: 162068 RVA: 0x003C5D6D File Offset: 0x003C3F6D
		static UScaleBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ScaleBox");
		}

		// Token: 0x06027915 RID: 162069 RVA: 0x003C5D7B File Offset: 0x003C3F7B
		protected UScaleBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AFA RID: 88826
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ScaleBox";

		// Token: 0x04015AFB RID: 88827
		private static IntPtr _ClassPtr;

		// Token: 0x04015AFC RID: 88828
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AFD RID: 88829
		internal static int __PropertyOffset_Stretch;

		// Token: 0x04015AFE RID: 88830
		internal static int __PropertyOffset_StretchDirection;

		// Token: 0x04015AFF RID: 88831
		internal static int __PropertyOffset_UserSpecifiedScale;

		// Token: 0x04015B00 RID: 88832
		internal static int __PropertyOffset_IgnoreInheritedScale;
	}
}
