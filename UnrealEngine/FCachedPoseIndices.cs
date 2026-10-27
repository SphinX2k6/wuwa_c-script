using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000905 RID: 2309
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CachedPoseIndices")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCachedPoseIndices : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007EB3 RID: 32435 RVA: 0x000B5C60 File Offset: 0x000B3E60
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedPoseIndices._ScriptStructPtr != 0) ? FCachedPoseIndices._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedPoseIndices", ref FCachedPoseIndices._ScriptStructPtr);
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06007EB4 RID: 32436 RVA: 0x000B5C84 File Offset: 0x000B3E84
		// (set) Token: 0x06007EB5 RID: 32437 RVA: 0x000B5CC7 File Offset: 0x000B3EC7
		public TArray<int> OrderedSavedPoseNodeIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._OrderedSavedPoseNodeIndices) == null)
				{
					result = (this._OrderedSavedPoseNodeIndices = new TArray<int>(base.NativePtr + (IntPtr)FCachedPoseIndices.__PropertyOffset_OrderedSavedPoseNodeIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OrderedSavedPoseNodeIndices.CopyAssign(value);
			}
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x000B5CD5 File Offset: 0x000B3ED5
		public FCachedPoseIndices()
		{
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x000B5CDD File Offset: 0x000B3EDD
		public FCachedPoseIndices(TArray<int> OrderedSavedPoseNodeIndices)
		{
			this.OrderedSavedPoseNodeIndices = OrderedSavedPoseNodeIndices;
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x000B5CEC File Offset: 0x000B3EEC
		protected override IntPtr GetUStructPtr()
		{
			return FCachedPoseIndices.StaticStruct();
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x000B5CF8 File Offset: 0x000B3EF8
		[NullableContext(2)]
		public FCachedPoseIndices(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x000B5D02 File Offset: 0x000B3F02
		public FCachedPoseIndices(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x000B5D0D File Offset: 0x000B3F0D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedPoseIndices(Pointer, false, true);
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x000B5D17 File Offset: 0x000B3F17
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedPoseIndices(Pointer, MemoryOwner);
		}

		// Token: 0x04003CC8 RID: 15560
		public const string __ObjectPath = "/Script/Engine.CachedPoseIndices";

		// Token: 0x04003CC9 RID: 15561
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CCA RID: 15562
		internal static int __PropertyOffset_OrderedSavedPoseNodeIndices;

		// Token: 0x04003CCB RID: 15563
		[Nullable(2)]
		private TArray<int> _OrderedSavedPoseNodeIndices;
	}
}
