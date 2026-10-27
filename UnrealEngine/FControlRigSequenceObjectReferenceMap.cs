using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004D0 RID: 1232
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigSequenceObjectReferenceMap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FControlRigSequenceObjectReferenceMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600423E RID: 16958 RVA: 0x0006308B File Offset: 0x0006128B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigSequenceObjectReferenceMap._ScriptStructPtr != 0) ? FControlRigSequenceObjectReferenceMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigSequenceObjectReferenceMap", ref FControlRigSequenceObjectReferenceMap._ScriptStructPtr);
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x000630B0 File Offset: 0x000612B0
		// (set) Token: 0x06004240 RID: 16960 RVA: 0x000630F3 File Offset: 0x000612F3
		public TArray<FGuid> BindingIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._BindingIds) == null)
				{
					result = (this._BindingIds = new TArray<FGuid>(base.NativePtr + (IntPtr)FControlRigSequenceObjectReferenceMap.__PropertyOffset_BindingIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BindingIds.CopyAssign(value);
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x00063104 File Offset: 0x00061304
		// (set) Token: 0x06004242 RID: 16962 RVA: 0x00063147 File Offset: 0x00061347
		public TArray<FControlRigSequenceObjectReferences> References
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FControlRigSequenceObjectReferences> result;
				if ((result = this._References) == null)
				{
					result = (this._References = new TArray<FControlRigSequenceObjectReferences>(base.NativePtr + (IntPtr)FControlRigSequenceObjectReferenceMap.__PropertyOffset_References, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.References.CopyAssign(value);
			}
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00063155 File Offset: 0x00061355
		public FControlRigSequenceObjectReferenceMap()
		{
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x0006315D File Offset: 0x0006135D
		public FControlRigSequenceObjectReferenceMap(TArray<FGuid> BindingIds, TArray<FControlRigSequenceObjectReferences> References)
		{
			this.BindingIds = BindingIds;
			this.References = References;
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00063173 File Offset: 0x00061373
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigSequenceObjectReferenceMap.StaticStruct();
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x0006317F File Offset: 0x0006137F
		[NullableContext(2)]
		public FControlRigSequenceObjectReferenceMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00063189 File Offset: 0x00061389
		public FControlRigSequenceObjectReferenceMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00063194 File Offset: 0x00061394
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigSequenceObjectReferenceMap(Pointer, false, true);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x0006319E File Offset: 0x0006139E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigSequenceObjectReferenceMap(Pointer, MemoryOwner);
		}

		// Token: 0x04001F7C RID: 8060
		public const string __ObjectPath = "/Script/ControlRig.ControlRigSequenceObjectReferenceMap";

		// Token: 0x04001F7D RID: 8061
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F7E RID: 8062
		internal static int __PropertyOffset_BindingIds;

		// Token: 0x04001F7F RID: 8063
		[Nullable(2)]
		private TArray<FGuid> _BindingIds;

		// Token: 0x04001F80 RID: 8064
		internal static int __PropertyOffset_References;

		// Token: 0x04001F81 RID: 8065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FControlRigSequenceObjectReferences> _References;
	}
}
