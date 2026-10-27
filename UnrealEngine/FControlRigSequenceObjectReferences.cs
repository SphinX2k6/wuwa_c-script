using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004D1 RID: 1233
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigSequenceObjectReferences")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FControlRigSequenceObjectReferences : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600424A RID: 16970 RVA: 0x000631A7 File Offset: 0x000613A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigSequenceObjectReferences._ScriptStructPtr != 0) ? FControlRigSequenceObjectReferences._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigSequenceObjectReferences", ref FControlRigSequenceObjectReferences._ScriptStructPtr);
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x000631CC File Offset: 0x000613CC
		// (set) Token: 0x0600424C RID: 16972 RVA: 0x0006320F File Offset: 0x0006140F
		public TArray<FControlRigSequenceObjectReference> Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FControlRigSequenceObjectReference> result;
				if ((result = this._Array) == null)
				{
					result = (this._Array = new TArray<FControlRigSequenceObjectReference>(base.NativePtr + (IntPtr)FControlRigSequenceObjectReferences.__PropertyOffset_Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Array.CopyAssign(value);
			}
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x0006321D File Offset: 0x0006141D
		public FControlRigSequenceObjectReferences()
		{
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00063225 File Offset: 0x00061425
		public FControlRigSequenceObjectReferences(TArray<FControlRigSequenceObjectReference> Array)
		{
			this.Array = Array;
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00063234 File Offset: 0x00061434
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigSequenceObjectReferences.StaticStruct();
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00063240 File Offset: 0x00061440
		[NullableContext(2)]
		public FControlRigSequenceObjectReferences(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x0006324A File Offset: 0x0006144A
		public FControlRigSequenceObjectReferences(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x00063255 File Offset: 0x00061455
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigSequenceObjectReferences(Pointer, false, true);
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x0006325F File Offset: 0x0006145F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigSequenceObjectReferences(Pointer, MemoryOwner);
		}

		// Token: 0x04001F82 RID: 8066
		public const string __ObjectPath = "/Script/ControlRig.ControlRigSequenceObjectReferences";

		// Token: 0x04001F83 RID: 8067
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F84 RID: 8068
		internal static int __PropertyOffset_Array;

		// Token: 0x04001F85 RID: 8069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FControlRigSequenceObjectReference> _Array;
	}
}
