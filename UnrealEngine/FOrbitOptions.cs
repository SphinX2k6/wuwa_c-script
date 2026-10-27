using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F37 RID: 3895
	[UnrealObjectPath("/Script/Engine.OrbitOptions")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FOrbitOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D207 RID: 53767 RVA: 0x00133D2C File Offset: 0x00131F2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOrbitOptions._ScriptStructPtr != 0) ? FOrbitOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.OrbitOptions", ref FOrbitOptions._ScriptStructPtr);
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600D208 RID: 53768 RVA: 0x00133D50 File Offset: 0x00131F50
		// (set) Token: 0x0600D209 RID: 53769 RVA: 0x00133D69 File Offset: 0x00131F69
		public unsafe bool bProcessDuringSpawn
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bProcessDuringSpawn) & FOrbitOptions.__PropertyMask_bProcessDuringSpawn) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bProcessDuringSpawn) = ((*(base.NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bProcessDuringSpawn) & ~FOrbitOptions.__PropertyMask_bProcessDuringSpawn) | (value ? FOrbitOptions.__PropertyMask_bProcessDuringSpawn : 0));
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600D20A RID: 53770 RVA: 0x00133D99 File Offset: 0x00131F99
		// (set) Token: 0x0600D20B RID: 53771 RVA: 0x00133DB2 File Offset: 0x00131FB2
		public unsafe bool bProcessDuringUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bProcessDuringUpdate) & FOrbitOptions.__PropertyMask_bProcessDuringUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bProcessDuringUpdate) = ((*(base.NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bProcessDuringUpdate) & ~FOrbitOptions.__PropertyMask_bProcessDuringUpdate) | (value ? FOrbitOptions.__PropertyMask_bProcessDuringUpdate : 0));
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600D20C RID: 53772 RVA: 0x00133DE2 File Offset: 0x00131FE2
		// (set) Token: 0x0600D20D RID: 53773 RVA: 0x00133DFB File Offset: 0x00131FFB
		public unsafe bool bUseEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bUseEmitterTime) & FOrbitOptions.__PropertyMask_bUseEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bUseEmitterTime) = ((*(base.NativePtr + (IntPtr)FOrbitOptions.__PropertyOffset_bUseEmitterTime) & ~FOrbitOptions.__PropertyMask_bUseEmitterTime) | (value ? FOrbitOptions.__PropertyMask_bUseEmitterTime : 0));
			}
		}

		// Token: 0x0600D20E RID: 53774 RVA: 0x00133E2B File Offset: 0x0013202B
		public FOrbitOptions()
		{
		}

		// Token: 0x0600D20F RID: 53775 RVA: 0x00133E33 File Offset: 0x00132033
		public FOrbitOptions(bool bProcessDuringSpawn, bool bProcessDuringUpdate, bool bUseEmitterTime)
		{
			this.bProcessDuringSpawn = bProcessDuringSpawn;
			this.bProcessDuringUpdate = bProcessDuringUpdate;
			this.bUseEmitterTime = bUseEmitterTime;
		}

		// Token: 0x0600D210 RID: 53776 RVA: 0x00133E50 File Offset: 0x00132050
		protected override IntPtr GetUStructPtr()
		{
			return FOrbitOptions.StaticStruct();
		}

		// Token: 0x0600D211 RID: 53777 RVA: 0x00133E5C File Offset: 0x0013205C
		[NullableContext(2)]
		public FOrbitOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D212 RID: 53778 RVA: 0x00133E66 File Offset: 0x00132066
		public FOrbitOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x00133E71 File Offset: 0x00132071
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOrbitOptions(Pointer, false, true);
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x00133E7B File Offset: 0x0013207B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOrbitOptions(Pointer, MemoryOwner);
		}

		// Token: 0x040070B8 RID: 28856
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OrbitOptions";

		// Token: 0x040070B9 RID: 28857
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070BA RID: 28858
		internal static int __PropertyOffset_bProcessDuringSpawn;

		// Token: 0x040070BB RID: 28859
		internal static byte __PropertyMask_bProcessDuringSpawn;

		// Token: 0x040070BC RID: 28860
		internal static int __PropertyOffset_bProcessDuringUpdate;

		// Token: 0x040070BD RID: 28861
		internal static byte __PropertyMask_bProcessDuringUpdate;

		// Token: 0x040070BE RID: 28862
		internal static int __PropertyOffset_bUseEmitterTime;

		// Token: 0x040070BF RID: 28863
		internal static byte __PropertyMask_bUseEmitterTime;
	}
}
