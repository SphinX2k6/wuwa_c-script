using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000939 RID: 2361
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClothingAssetData_Legacy")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FClothingAssetData_Legacy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008562 RID: 34146 RVA: 0x000BE392 File Offset: 0x000BC592
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothingAssetData_Legacy._ScriptStructPtr != 0) ? FClothingAssetData_Legacy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClothingAssetData_Legacy", ref FClothingAssetData_Legacy._ScriptStructPtr);
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x000BE3B6 File Offset: 0x000BC5B6
		// (set) Token: 0x06008564 RID: 34148 RVA: 0x000BE3CA File Offset: 0x000BC5CA
		public unsafe FName AssetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothingAssetData_Legacy.__PropertyOffset_AssetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothingAssetData_Legacy.__PropertyOffset_AssetName) = value;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x000BE3DF File Offset: 0x000BC5DF
		// (set) Token: 0x06008566 RID: 34150 RVA: 0x000BE3F3 File Offset: 0x000BC5F3
		public unsafe string ApexFileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FClothingAssetData_Legacy.__PropertyOffset_ApexFileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FClothingAssetData_Legacy.__PropertyOffset_ApexFileName)), value);
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x000BE408 File Offset: 0x000BC608
		// (set) Token: 0x06008568 RID: 34152 RVA: 0x000BE418 File Offset: 0x000BC618
		public unsafe bool bClothPropertiesChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothingAssetData_Legacy.__PropertyOffset_bClothPropertiesChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothingAssetData_Legacy.__PropertyOffset_bClothPropertiesChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06008569 RID: 34153 RVA: 0x000BE42C File Offset: 0x000BC62C
		// (set) Token: 0x0600856A RID: 34154 RVA: 0x000BE46F File Offset: 0x000BC66F
		public FClothPhysicsProperties_Legacy PhysicsProperties
		{
			get
			{
				base.FastCheckIsValid();
				FClothPhysicsProperties_Legacy result;
				if ((result = this._PhysicsProperties) == null)
				{
					result = (this._PhysicsProperties = new FClothPhysicsProperties_Legacy(base.NativePtr + (IntPtr)FClothingAssetData_Legacy.__PropertyOffset_PhysicsProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothPhysicsProperties_Legacy.StaticStruct(), base.NativePtr + (IntPtr)FClothingAssetData_Legacy.__PropertyOffset_PhysicsProperties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x000BE490 File Offset: 0x000BC690
		public FClothingAssetData_Legacy()
		{
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x000BE498 File Offset: 0x000BC698
		public FClothingAssetData_Legacy(FName AssetName, string ApexFileName, bool bClothPropertiesChanged, FClothPhysicsProperties_Legacy PhysicsProperties)
		{
			this.AssetName = AssetName;
			this.ApexFileName = ApexFileName;
			this.bClothPropertiesChanged = bClothPropertiesChanged;
			this.PhysicsProperties = PhysicsProperties;
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x000BE4BD File Offset: 0x000BC6BD
		protected override IntPtr GetUStructPtr()
		{
			return FClothingAssetData_Legacy.StaticStruct();
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x000BE4C9 File Offset: 0x000BC6C9
		[NullableContext(2)]
		public FClothingAssetData_Legacy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x000BE4D3 File Offset: 0x000BC6D3
		public FClothingAssetData_Legacy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x000BE4DE File Offset: 0x000BC6DE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothingAssetData_Legacy(Pointer, false, true);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x000BE4E8 File Offset: 0x000BC6E8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothingAssetData_Legacy(Pointer, MemoryOwner);
		}

		// Token: 0x04003F79 RID: 16249
		public const string __ObjectPath = "/Script/Engine.ClothingAssetData_Legacy";

		// Token: 0x04003F7A RID: 16250
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F7B RID: 16251
		internal static int __PropertyOffset_AssetName;

		// Token: 0x04003F7C RID: 16252
		internal static int __PropertyOffset_ApexFileName;

		// Token: 0x04003F7D RID: 16253
		internal static int __PropertyOffset_bClothPropertiesChanged;

		// Token: 0x04003F7E RID: 16254
		internal static int __PropertyOffset_PhysicsProperties;

		// Token: 0x04003F7F RID: 16255
		[Nullable(2)]
		private FClothPhysicsProperties_Legacy _PhysicsProperties;
	}
}
