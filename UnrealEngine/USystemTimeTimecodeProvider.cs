using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011BF RID: 4543
	[UnrealObjectPath("/Script/Engine.SystemTimeTimecodeProvider")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class USystemTimeTimecodeProvider : UTimecodeProvider, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010C01 RID: 68609 RVA: 0x00189634 File Offset: 0x00187834
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USystemTimeTimecodeProvider._ClassPtr;
		}

		// Token: 0x06010C02 RID: 68610 RVA: 0x00189640 File Offset: 0x00187840
		public USystemTimeTimecodeProvider() : this(BuiltinUtils.AllocNativeUObject(USystemTimeTimecodeProvider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010C03 RID: 68611 RVA: 0x00189668 File Offset: 0x00187868
		[NullableContext(1)]
		public USystemTimeTimecodeProvider(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USystemTimeTimecodeProvider.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x06010C04 RID: 68612 RVA: 0x0018969B File Offset: 0x0018789B
		// (set) Token: 0x06010C05 RID: 68613 RVA: 0x001896AF File Offset: 0x001878AF
		public unsafe FFrameRate FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USystemTimeTimecodeProvider.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USystemTimeTimecodeProvider.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x06010C06 RID: 68614 RVA: 0x001896C4 File Offset: 0x001878C4
		// (set) Token: 0x06010C07 RID: 68615 RVA: 0x001896D4 File Offset: 0x001878D4
		public unsafe bool bGenerateFullFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USystemTimeTimecodeProvider.__PropertyOffset_bGenerateFullFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USystemTimeTimecodeProvider.__PropertyOffset_bGenerateFullFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x06010C08 RID: 68616 RVA: 0x001896E5 File Offset: 0x001878E5
		// (set) Token: 0x06010C09 RID: 68617 RVA: 0x001896F5 File Offset: 0x001878F5
		public unsafe bool bUseHighPerformanceClock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USystemTimeTimecodeProvider.__PropertyOffset_bUseHighPerformanceClock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USystemTimeTimecodeProvider.__PropertyOffset_bUseHighPerformanceClock) = (value ? 1 : 0);
			}
		}

		// Token: 0x06010C0A RID: 68618 RVA: 0x00189706 File Offset: 0x00187906
		static USystemTimeTimecodeProvider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SystemTimeTimecodeProvider");
		}

		// Token: 0x06010C0B RID: 68619 RVA: 0x00189714 File Offset: 0x00187914
		protected USystemTimeTimecodeProvider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F3F RID: 36671
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SystemTimeTimecodeProvider";

		// Token: 0x04008F40 RID: 36672
		private static IntPtr _ClassPtr;

		// Token: 0x04008F41 RID: 36673
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F42 RID: 36674
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04008F43 RID: 36675
		internal static int __PropertyOffset_bGenerateFullFrame;

		// Token: 0x04008F44 RID: 36676
		internal static int __PropertyOffset_bUseHighPerformanceClock;
	}
}
