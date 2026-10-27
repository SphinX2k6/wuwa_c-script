using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C9 RID: 9673
	[UnrealObjectPath("/Script/Niagara.NiagaraPlatformSetConflictEntry")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraPlatformSetConflictEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F45 RID: 147269 RVA: 0x00352DDA File Offset: 0x00350FDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraPlatformSetConflictEntry._ScriptStructPtr != 0) ? FNiagaraPlatformSetConflictEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraPlatformSetConflictEntry", ref FNiagaraPlatformSetConflictEntry._ScriptStructPtr);
		}

		// Token: 0x17008A41 RID: 35393
		// (get) Token: 0x06023F46 RID: 147270 RVA: 0x00352DFE File Offset: 0x00350FFE
		// (set) Token: 0x06023F47 RID: 147271 RVA: 0x00352E12 File Offset: 0x00351012
		public unsafe FName ProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictEntry.__PropertyOffset_ProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictEntry.__PropertyOffset_ProfileName) = value;
			}
		}

		// Token: 0x17008A42 RID: 35394
		// (get) Token: 0x06023F48 RID: 147272 RVA: 0x00352E27 File Offset: 0x00351027
		// (set) Token: 0x06023F49 RID: 147273 RVA: 0x00352E37 File Offset: 0x00351037
		public unsafe int QualityLevelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictEntry.__PropertyOffset_QualityLevelMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictEntry.__PropertyOffset_QualityLevelMask) = value;
			}
		}

		// Token: 0x06023F4A RID: 147274 RVA: 0x00352E48 File Offset: 0x00351048
		public FNiagaraPlatformSetConflictEntry()
		{
		}

		// Token: 0x06023F4B RID: 147275 RVA: 0x00352E50 File Offset: 0x00351050
		public FNiagaraPlatformSetConflictEntry(FName ProfileName, int QualityLevelMask)
		{
			this.ProfileName = ProfileName;
			this.QualityLevelMask = QualityLevelMask;
		}

		// Token: 0x06023F4C RID: 147276 RVA: 0x00352E66 File Offset: 0x00351066
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraPlatformSetConflictEntry.StaticStruct();
		}

		// Token: 0x06023F4D RID: 147277 RVA: 0x00352E72 File Offset: 0x00351072
		[NullableContext(2)]
		public FNiagaraPlatformSetConflictEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F4E RID: 147278 RVA: 0x00352E7C File Offset: 0x0035107C
		public FNiagaraPlatformSetConflictEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F4F RID: 147279 RVA: 0x00352E87 File Offset: 0x00351087
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraPlatformSetConflictEntry(Pointer, false, true);
		}

		// Token: 0x06023F50 RID: 147280 RVA: 0x00352E91 File Offset: 0x00351091
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraPlatformSetConflictEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0401346D RID: 78957
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraPlatformSetConflictEntry";

		// Token: 0x0401346E RID: 78958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401346F RID: 78959
		internal static int __PropertyOffset_ProfileName;

		// Token: 0x04013470 RID: 78960
		internal static int __PropertyOffset_QualityLevelMask;
	}
}
