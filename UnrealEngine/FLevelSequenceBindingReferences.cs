using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FB5 RID: 8117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceBindingReferences")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FLevelSequenceBindingReferences : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ED00 RID: 126208 RVA: 0x002DCBC4 File Offset: 0x002DADC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceBindingReferences._ScriptStructPtr != 0) ? FLevelSequenceBindingReferences._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceBindingReferences", ref FLevelSequenceBindingReferences._ScriptStructPtr);
		}

		// Token: 0x17007AB4 RID: 31412
		// (get) Token: 0x0601ED01 RID: 126209 RVA: 0x002DCBE8 File Offset: 0x002DADE8
		// (set) Token: 0x0601ED02 RID: 126210 RVA: 0x002DCC2B File Offset: 0x002DAE2B
		public TMap<FGuid, FLevelSequenceBindingReferenceArray> BindingIdToReferences
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FLevelSequenceBindingReferenceArray> result;
				if ((result = this._BindingIdToReferences) == null)
				{
					result = (this._BindingIdToReferences = new TMap<FGuid, FLevelSequenceBindingReferenceArray>(base.NativePtr + (IntPtr)FLevelSequenceBindingReferences.__PropertyOffset_BindingIdToReferences, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BindingIdToReferences.CopyAssign(value);
			}
		}

		// Token: 0x17007AB5 RID: 31413
		// (get) Token: 0x0601ED03 RID: 126211 RVA: 0x002DCC3C File Offset: 0x002DAE3C
		// (set) Token: 0x0601ED04 RID: 126212 RVA: 0x002DCC7F File Offset: 0x002DAE7F
		public TSet<FGuid> AnimSequenceInstances
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FGuid> result;
				if ((result = this._AnimSequenceInstances) == null)
				{
					result = (this._AnimSequenceInstances = new TSet<FGuid>(base.NativePtr + (IntPtr)FLevelSequenceBindingReferences.__PropertyOffset_AnimSequenceInstances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimSequenceInstances.CopyAssign(value);
			}
		}

		// Token: 0x0601ED05 RID: 126213 RVA: 0x002DCC8D File Offset: 0x002DAE8D
		public FLevelSequenceBindingReferences()
		{
		}

		// Token: 0x0601ED06 RID: 126214 RVA: 0x002DCC95 File Offset: 0x002DAE95
		public FLevelSequenceBindingReferences(TMap<FGuid, FLevelSequenceBindingReferenceArray> BindingIdToReferences, TSet<FGuid> AnimSequenceInstances)
		{
			this.BindingIdToReferences = BindingIdToReferences;
			this.AnimSequenceInstances = AnimSequenceInstances;
		}

		// Token: 0x0601ED07 RID: 126215 RVA: 0x002DCCAB File Offset: 0x002DAEAB
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceBindingReferences.StaticStruct();
		}

		// Token: 0x0601ED08 RID: 126216 RVA: 0x002DCCB7 File Offset: 0x002DAEB7
		[NullableContext(2)]
		public FLevelSequenceBindingReferences(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ED09 RID: 126217 RVA: 0x002DCCC1 File Offset: 0x002DAEC1
		public FLevelSequenceBindingReferences(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ED0A RID: 126218 RVA: 0x002DCCCC File Offset: 0x002DAECC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceBindingReferences(Pointer, false, true);
		}

		// Token: 0x0601ED0B RID: 126219 RVA: 0x002DCCD6 File Offset: 0x002DAED6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceBindingReferences(Pointer, MemoryOwner);
		}

		// Token: 0x04010A75 RID: 68213
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceBindingReferences";

		// Token: 0x04010A76 RID: 68214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A77 RID: 68215
		internal static int __PropertyOffset_BindingIdToReferences;

		// Token: 0x04010A78 RID: 68216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, FLevelSequenceBindingReferenceArray> _BindingIdToReferences;

		// Token: 0x04010A79 RID: 68217
		internal static int __PropertyOffset_AnimSequenceInstances;

		// Token: 0x04010A7A RID: 68218
		[Nullable(2)]
		private TSet<FGuid> _AnimSequenceInstances;
	}
}
