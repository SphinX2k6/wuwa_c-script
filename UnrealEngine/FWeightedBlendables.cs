using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001246 RID: 4678
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WeightedBlendables")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWeightedBlendables : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011310 RID: 70416 RVA: 0x00193935 File Offset: 0x00191B35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWeightedBlendables._ScriptStructPtr != 0) ? FWeightedBlendables._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WeightedBlendables", ref FWeightedBlendables._ScriptStructPtr);
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x06011311 RID: 70417 RVA: 0x0019395C File Offset: 0x00191B5C
		// (set) Token: 0x06011312 RID: 70418 RVA: 0x0019399F File Offset: 0x00191B9F
		public TArray<FWeightedBlendable> Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWeightedBlendable> result;
				if ((result = this._Array) == null)
				{
					result = (this._Array = new TArray<FWeightedBlendable>(base.NativePtr + (IntPtr)FWeightedBlendables.__PropertyOffset_Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Array.CopyAssign(value);
			}
		}

		// Token: 0x06011313 RID: 70419 RVA: 0x001939AD File Offset: 0x00191BAD
		public FWeightedBlendables()
		{
		}

		// Token: 0x06011314 RID: 70420 RVA: 0x001939B5 File Offset: 0x00191BB5
		public FWeightedBlendables(TArray<FWeightedBlendable> Array)
		{
			this.Array = Array;
		}

		// Token: 0x06011315 RID: 70421 RVA: 0x001939C4 File Offset: 0x00191BC4
		protected override IntPtr GetUStructPtr()
		{
			return FWeightedBlendables.StaticStruct();
		}

		// Token: 0x06011316 RID: 70422 RVA: 0x001939D0 File Offset: 0x00191BD0
		[NullableContext(2)]
		public FWeightedBlendables(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011317 RID: 70423 RVA: 0x001939DA File Offset: 0x00191BDA
		public FWeightedBlendables(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011318 RID: 70424 RVA: 0x001939E5 File Offset: 0x00191BE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWeightedBlendables(Pointer, false, true);
		}

		// Token: 0x06011319 RID: 70425 RVA: 0x001939EF File Offset: 0x00191BEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWeightedBlendables(Pointer, MemoryOwner);
		}

		// Token: 0x04009318 RID: 37656
		public const string __ObjectPath = "/Script/Engine.WeightedBlendables";

		// Token: 0x04009319 RID: 37657
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400931A RID: 37658
		internal static int __PropertyOffset_Array;

		// Token: 0x0400931B RID: 37659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWeightedBlendable> _Array;
	}
}
