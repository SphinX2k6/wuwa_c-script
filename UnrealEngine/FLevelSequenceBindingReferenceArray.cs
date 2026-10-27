using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FB4 RID: 8116
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceBindingReferenceArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLevelSequenceBindingReferenceArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ECF6 RID: 126198 RVA: 0x002DCB02 File Offset: 0x002DAD02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceBindingReferenceArray._ScriptStructPtr != 0) ? FLevelSequenceBindingReferenceArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceBindingReferenceArray", ref FLevelSequenceBindingReferenceArray._ScriptStructPtr);
		}

		// Token: 0x17007AB3 RID: 31411
		// (get) Token: 0x0601ECF7 RID: 126199 RVA: 0x002DCB28 File Offset: 0x002DAD28
		// (set) Token: 0x0601ECF8 RID: 126200 RVA: 0x002DCB6B File Offset: 0x002DAD6B
		public TArray<FLevelSequenceBindingReference> References
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLevelSequenceBindingReference> result;
				if ((result = this._References) == null)
				{
					result = (this._References = new TArray<FLevelSequenceBindingReference>(base.NativePtr + (IntPtr)FLevelSequenceBindingReferenceArray.__PropertyOffset_References, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.References.CopyAssign(value);
			}
		}

		// Token: 0x0601ECF9 RID: 126201 RVA: 0x002DCB79 File Offset: 0x002DAD79
		public FLevelSequenceBindingReferenceArray()
		{
		}

		// Token: 0x0601ECFA RID: 126202 RVA: 0x002DCB81 File Offset: 0x002DAD81
		public FLevelSequenceBindingReferenceArray(TArray<FLevelSequenceBindingReference> References)
		{
			this.References = References;
		}

		// Token: 0x0601ECFB RID: 126203 RVA: 0x002DCB90 File Offset: 0x002DAD90
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceBindingReferenceArray.StaticStruct();
		}

		// Token: 0x0601ECFC RID: 126204 RVA: 0x002DCB9C File Offset: 0x002DAD9C
		[NullableContext(2)]
		public FLevelSequenceBindingReferenceArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ECFD RID: 126205 RVA: 0x002DCBA6 File Offset: 0x002DADA6
		public FLevelSequenceBindingReferenceArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ECFE RID: 126206 RVA: 0x002DCBB1 File Offset: 0x002DADB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceBindingReferenceArray(Pointer, false, true);
		}

		// Token: 0x0601ECFF RID: 126207 RVA: 0x002DCBBB File Offset: 0x002DADBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceBindingReferenceArray(Pointer, MemoryOwner);
		}

		// Token: 0x04010A71 RID: 68209
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceBindingReferenceArray";

		// Token: 0x04010A72 RID: 68210
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A73 RID: 68211
		internal static int __PropertyOffset_References;

		// Token: 0x04010A74 RID: 68212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLevelSequenceBindingReference> _References;
	}
}
