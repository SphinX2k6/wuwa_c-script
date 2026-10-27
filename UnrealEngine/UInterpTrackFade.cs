using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C91 RID: 3217
	[UnrealObjectPath("/Script/Engine.InterpTrackFade")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UInterpTrackFade : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A342 RID: 41794 RVA: 0x000E8006 File Offset: 0x000E6206
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackFade._ClassPtr;
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x000E8014 File Offset: 0x000E6214
		public UInterpTrackFade() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x000E803C File Offset: 0x000E623C
		[NullableContext(1)]
		public UInterpTrackFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x0600A345 RID: 41797 RVA: 0x000E806F File Offset: 0x000E626F
		// (set) Token: 0x0600A346 RID: 41798 RVA: 0x000E8088 File Offset: 0x000E6288
		public unsafe bool bPersistFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_bPersistFade) & UInterpTrackFade.__PropertyMask_bPersistFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_bPersistFade) = ((*(base.NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_bPersistFade) & ~UInterpTrackFade.__PropertyMask_bPersistFade) | (value ? UInterpTrackFade.__PropertyMask_bPersistFade : 0));
			}
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x0600A347 RID: 41799 RVA: 0x000E80B8 File Offset: 0x000E62B8
		// (set) Token: 0x0600A348 RID: 41800 RVA: 0x000E80D1 File Offset: 0x000E62D1
		public unsafe bool bFadeAudio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_bFadeAudio) & UInterpTrackFade.__PropertyMask_bFadeAudio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_bFadeAudio) = ((*(base.NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_bFadeAudio) & ~UInterpTrackFade.__PropertyMask_bFadeAudio) | (value ? UInterpTrackFade.__PropertyMask_bFadeAudio : 0));
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600A349 RID: 41801 RVA: 0x000E8101 File Offset: 0x000E6301
		// (set) Token: 0x0600A34A RID: 41802 RVA: 0x000E8115 File Offset: 0x000E6315
		public unsafe FLinearColor FadeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_FadeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFade.__PropertyOffset_FadeColor) = value;
			}
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x000E812A File Offset: 0x000E632A
		static UInterpTrackFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackFade");
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x000E8138 File Offset: 0x000E6338
		protected UInterpTrackFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059B2 RID: 22962
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackFade";

		// Token: 0x040059B3 RID: 22963
		private static IntPtr _ClassPtr;

		// Token: 0x040059B4 RID: 22964
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059B5 RID: 22965
		internal static int __PropertyOffset_bPersistFade;

		// Token: 0x040059B6 RID: 22966
		internal static byte __PropertyMask_bPersistFade;

		// Token: 0x040059B7 RID: 22967
		internal static int __PropertyOffset_bFadeAudio;

		// Token: 0x040059B8 RID: 22968
		internal static byte __PropertyMask_bFadeAudio;

		// Token: 0x040059B9 RID: 22969
		internal static int __PropertyOffset_FadeColor;
	}
}
