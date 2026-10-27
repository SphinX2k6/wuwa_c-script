using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025CA RID: 9674
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraPlatformSetConflictInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraPlatformSetConflictInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F51 RID: 147281 RVA: 0x00352E9A File Offset: 0x0035109A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraPlatformSetConflictInfo._ScriptStructPtr != 0) ? FNiagaraPlatformSetConflictInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraPlatformSetConflictInfo", ref FNiagaraPlatformSetConflictInfo._ScriptStructPtr);
		}

		// Token: 0x17008A43 RID: 35395
		// (get) Token: 0x06023F52 RID: 147282 RVA: 0x00352EBE File Offset: 0x003510BE
		// (set) Token: 0x06023F53 RID: 147283 RVA: 0x00352ECE File Offset: 0x003510CE
		public unsafe int SetAIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictInfo.__PropertyOffset_SetAIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictInfo.__PropertyOffset_SetAIndex) = value;
			}
		}

		// Token: 0x17008A44 RID: 35396
		// (get) Token: 0x06023F54 RID: 147284 RVA: 0x00352EDF File Offset: 0x003510DF
		// (set) Token: 0x06023F55 RID: 147285 RVA: 0x00352EEF File Offset: 0x003510EF
		public unsafe int SetBIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictInfo.__PropertyOffset_SetBIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictInfo.__PropertyOffset_SetBIndex) = value;
			}
		}

		// Token: 0x17008A45 RID: 35397
		// (get) Token: 0x06023F56 RID: 147286 RVA: 0x00352F00 File Offset: 0x00351100
		// (set) Token: 0x06023F57 RID: 147287 RVA: 0x00352F43 File Offset: 0x00351143
		public TArray<FNiagaraPlatformSetConflictEntry> Conflicts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraPlatformSetConflictEntry> result;
				if ((result = this._Conflicts) == null)
				{
					result = (this._Conflicts = new TArray<FNiagaraPlatformSetConflictEntry>(base.NativePtr + (IntPtr)FNiagaraPlatformSetConflictInfo.__PropertyOffset_Conflicts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Conflicts.CopyAssign(value);
			}
		}

		// Token: 0x06023F58 RID: 147288 RVA: 0x00352F51 File Offset: 0x00351151
		public FNiagaraPlatformSetConflictInfo()
		{
		}

		// Token: 0x06023F59 RID: 147289 RVA: 0x00352F59 File Offset: 0x00351159
		public FNiagaraPlatformSetConflictInfo(int SetAIndex, int SetBIndex, TArray<FNiagaraPlatformSetConflictEntry> Conflicts)
		{
			this.SetAIndex = SetAIndex;
			this.SetBIndex = SetBIndex;
			this.Conflicts = Conflicts;
		}

		// Token: 0x06023F5A RID: 147290 RVA: 0x00352F76 File Offset: 0x00351176
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraPlatformSetConflictInfo.StaticStruct();
		}

		// Token: 0x06023F5B RID: 147291 RVA: 0x00352F82 File Offset: 0x00351182
		[NullableContext(2)]
		public FNiagaraPlatformSetConflictInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F5C RID: 147292 RVA: 0x00352F8C File Offset: 0x0035118C
		public FNiagaraPlatformSetConflictInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F5D RID: 147293 RVA: 0x00352F97 File Offset: 0x00351197
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraPlatformSetConflictInfo(Pointer, false, true);
		}

		// Token: 0x06023F5E RID: 147294 RVA: 0x00352FA1 File Offset: 0x003511A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraPlatformSetConflictInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013471 RID: 78961
		public const string __ObjectPath = "/Script/Niagara.NiagaraPlatformSetConflictInfo";

		// Token: 0x04013472 RID: 78962
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013473 RID: 78963
		internal static int __PropertyOffset_SetAIndex;

		// Token: 0x04013474 RID: 78964
		internal static int __PropertyOffset_SetBIndex;

		// Token: 0x04013475 RID: 78965
		internal static int __PropertyOffset_Conflicts;

		// Token: 0x04013476 RID: 78966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraPlatformSetConflictEntry> _Conflicts;
	}
}
