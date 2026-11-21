using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000283 RID: 643
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkelMeshSkinWeightInfo")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FSkelMeshSkinWeightInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044B2 RID: 17586 RVA: 0x00061725 File Offset: 0x0005F925
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkelMeshSkinWeightInfo._ScriptStructPtr != 0) ? FSkelMeshSkinWeightInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkelMeshSkinWeightInfo", ref FSkelMeshSkinWeightInfo._ScriptStructPtr);
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x0006174C File Offset: 0x0005F94C
		// (set) Token: 0x060044B4 RID: 17588 RVA: 0x00061791 File Offset: 0x0005F991
		public TFixedArray<int> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TFixedArray<int>(base.NativePtr + (IntPtr)FSkelMeshSkinWeightInfo.__PropertyOffset_Bones, 12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x000617A0 File Offset: 0x0005F9A0
		// (set) Token: 0x060044B6 RID: 17590 RVA: 0x000617E5 File Offset: 0x0005F9E5
		public TFixedArray<byte> Weights
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<byte> result;
				if ((result = this._Weights) == null)
				{
					result = (this._Weights = new TFixedArray<byte>(base.NativePtr + (IntPtr)FSkelMeshSkinWeightInfo.__PropertyOffset_Weights, 12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Weights.CopyAssign(value);
			}
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x000617F3 File Offset: 0x0005F9F3
		public FSkelMeshSkinWeightInfo()
		{
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x000617FB File Offset: 0x0005F9FB
		protected override IntPtr GetUStructPtr()
		{
			return FSkelMeshSkinWeightInfo.StaticStruct();
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00061807 File Offset: 0x0005FA07
		[NullableContext(2)]
		public FSkelMeshSkinWeightInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00061811 File Offset: 0x0005FA11
		public FSkelMeshSkinWeightInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x0006181C File Offset: 0x0005FA1C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkelMeshSkinWeightInfo(Pointer, false, true);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00061826 File Offset: 0x0005FA26
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkelMeshSkinWeightInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04001AE1 RID: 6881
		public const string __ObjectPath = "/Script/Engine.SkelMeshSkinWeightInfo";

		// Token: 0x04001AE2 RID: 6882
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001AE3 RID: 6883
		internal static int __PropertyOffset_Bones;

		// Token: 0x04001AE4 RID: 6884
		[Nullable(2)]
		private TFixedArray<int> _Bones;

		// Token: 0x04001AE5 RID: 6885
		internal static int __PropertyOffset_Weights;

		// Token: 0x04001AE6 RID: 6886
		[Nullable(2)]
		private TFixedArray<byte> _Weights;
	}
}
