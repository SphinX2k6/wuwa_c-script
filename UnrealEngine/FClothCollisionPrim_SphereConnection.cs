using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200048D RID: 1165
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_SphereConnection")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FClothCollisionPrim_SphereConnection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003EA0 RID: 16032 RVA: 0x0005E303 File Offset: 0x0005C503
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothCollisionPrim_SphereConnection._ScriptStructPtr != 0) ? FClothCollisionPrim_SphereConnection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_SphereConnection", ref FClothCollisionPrim_SphereConnection._ScriptStructPtr);
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x0005E328 File Offset: 0x0005C528
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x0005E36C File Offset: 0x0005C56C
		public TFixedArray<int> SphereIndices
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._SphereIndices) == null)
				{
					result = (this._SphereIndices = new TFixedArray<int>(base.NativePtr + (IntPtr)FClothCollisionPrim_SphereConnection.__PropertyOffset_SphereIndices, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphereIndices.CopyAssign(value);
			}
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0005E37A File Offset: 0x0005C57A
		public FClothCollisionPrim_SphereConnection()
		{
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0005E382 File Offset: 0x0005C582
		public FClothCollisionPrim_SphereConnection(TFixedArray<int> SphereIndices)
		{
			this.SphereIndices = SphereIndices;
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x0005E391 File Offset: 0x0005C591
		protected override IntPtr GetUStructPtr()
		{
			return FClothCollisionPrim_SphereConnection.StaticStruct();
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x0005E39D File Offset: 0x0005C59D
		[NullableContext(2)]
		public FClothCollisionPrim_SphereConnection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x0005E3A7 File Offset: 0x0005C5A7
		public FClothCollisionPrim_SphereConnection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x0005E3B2 File Offset: 0x0005C5B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothCollisionPrim_SphereConnection(Pointer, false, true);
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0005E3BC File Offset: 0x0005C5BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothCollisionPrim_SphereConnection(Pointer, MemoryOwner);
		}

		// Token: 0x04001D87 RID: 7559
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_SphereConnection";

		// Token: 0x04001D88 RID: 7560
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D89 RID: 7561
		internal static int __PropertyOffset_SphereIndices;

		// Token: 0x04001D8A RID: 7562
		[Nullable(2)]
		private TFixedArray<int> _SphereIndices;
	}
}
