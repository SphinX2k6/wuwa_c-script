using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001157 RID: 4439
	[UnrealObjectPath("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSoundSubmixSpectralAnalysisBandSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010387 RID: 66439 RVA: 0x0017E714 File Offset: 0x0017C914
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundSubmixSpectralAnalysisBandSettings._ScriptStructPtr != 0) ? FSoundSubmixSpectralAnalysisBandSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings", ref FSoundSubmixSpectralAnalysisBandSettings._ScriptStructPtr);
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x06010388 RID: 66440 RVA: 0x0017E738 File Offset: 0x0017C938
		// (set) Token: 0x06010389 RID: 66441 RVA: 0x0017E748 File Offset: 0x0017C948
		public unsafe float BandFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_BandFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_BandFrequency) = value;
			}
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x0601038A RID: 66442 RVA: 0x0017E759 File Offset: 0x0017C959
		// (set) Token: 0x0601038B RID: 66443 RVA: 0x0017E769 File Offset: 0x0017C969
		public unsafe int AttackTimeMsec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_AttackTimeMsec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_AttackTimeMsec) = value;
			}
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x0601038C RID: 66444 RVA: 0x0017E77A File Offset: 0x0017C97A
		// (set) Token: 0x0601038D RID: 66445 RVA: 0x0017E78A File Offset: 0x0017C98A
		public unsafe int ReleaseTimeMsec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_ReleaseTimeMsec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_ReleaseTimeMsec) = value;
			}
		}

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x0601038E RID: 66446 RVA: 0x0017E79B File Offset: 0x0017C99B
		// (set) Token: 0x0601038F RID: 66447 RVA: 0x0017E7AB File Offset: 0x0017C9AB
		public unsafe float QFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_QFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundSubmixSpectralAnalysisBandSettings.__PropertyOffset_QFactor) = value;
			}
		}

		// Token: 0x06010390 RID: 66448 RVA: 0x0017E7BC File Offset: 0x0017C9BC
		public FSoundSubmixSpectralAnalysisBandSettings()
		{
		}

		// Token: 0x06010391 RID: 66449 RVA: 0x0017E7C4 File Offset: 0x0017C9C4
		public FSoundSubmixSpectralAnalysisBandSettings(float BandFrequency, int AttackTimeMsec, int ReleaseTimeMsec, float QFactor)
		{
			this.BandFrequency = BandFrequency;
			this.AttackTimeMsec = AttackTimeMsec;
			this.ReleaseTimeMsec = ReleaseTimeMsec;
			this.QFactor = QFactor;
		}

		// Token: 0x06010392 RID: 66450 RVA: 0x0017E7E9 File Offset: 0x0017C9E9
		protected override IntPtr GetUStructPtr()
		{
			return FSoundSubmixSpectralAnalysisBandSettings.StaticStruct();
		}

		// Token: 0x06010393 RID: 66451 RVA: 0x0017E7F5 File Offset: 0x0017C9F5
		[NullableContext(2)]
		public FSoundSubmixSpectralAnalysisBandSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010394 RID: 66452 RVA: 0x0017E7FF File Offset: 0x0017C9FF
		public FSoundSubmixSpectralAnalysisBandSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010395 RID: 66453 RVA: 0x0017E80A File Offset: 0x0017CA0A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundSubmixSpectralAnalysisBandSettings(Pointer, false, true);
		}

		// Token: 0x06010396 RID: 66454 RVA: 0x0017E814 File Offset: 0x0017CA14
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundSubmixSpectralAnalysisBandSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008BA2 RID: 35746
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundSubmixSpectralAnalysisBandSettings";

		// Token: 0x04008BA3 RID: 35747
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BA4 RID: 35748
		internal static int __PropertyOffset_BandFrequency;

		// Token: 0x04008BA5 RID: 35749
		internal static int __PropertyOffset_AttackTimeMsec;

		// Token: 0x04008BA6 RID: 35750
		internal static int __PropertyOffset_ReleaseTimeMsec;

		// Token: 0x04008BA7 RID: 35751
		internal static int __PropertyOffset_QFactor;
	}
}
