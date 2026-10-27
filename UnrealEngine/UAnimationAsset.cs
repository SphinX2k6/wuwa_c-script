using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DD RID: 2013
	[UnrealObjectPath("/Script/Engine.AnimationAsset")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public abstract class UAnimationAsset : UObject, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface, IInterface_PreviewMeshProvider
	{
		// Token: 0x06006B4E RID: 27470 RVA: 0x0009A7CC File Offset: 0x000989CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimationAsset._ClassPtr;
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x0009A7D8 File Offset: 0x000989D8
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UAnimationAsset.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x0009A7DF File Offset: 0x000989DF
		int IInterface_PreviewMeshProvider.InterfaceOffset()
		{
			return UAnimationAsset.__InterfaceOffset_IInterface_PreviewMeshProvider;
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x0009A7E6 File Offset: 0x000989E6
		// (set) Token: 0x06006B52 RID: 27474 RVA: 0x0009A7FA File Offset: 0x000989FA
		[Nullable(2)]
		public unsafe USkeleton Skeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimationAsset.__PropertyOffset_Skeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimationAsset.__PropertyOffset_Skeleton, value);
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x0009A810 File Offset: 0x00098A10
		// (set) Token: 0x06006B54 RID: 27476 RVA: 0x0009A849 File Offset: 0x00098A49
		[Nullable(1)]
		public TArray<UAnimMetaData> MetaData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimMetaData> result;
				if ((result = this._MetaData) == null)
				{
					result = (this._MetaData = new TArray<UAnimMetaData>(base.NativePtr + (IntPtr)UAnimationAsset.__PropertyOffset_MetaData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MetaData.CopyAssign(value);
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06006B55 RID: 27477 RVA: 0x0009A858 File Offset: 0x00098A58
		// (set) Token: 0x06006B56 RID: 27478 RVA: 0x0009A891 File Offset: 0x00098A91
		[Nullable(1)]
		public TArray<UAssetUserData> AssetUserData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UAnimationAsset.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x0009A89F File Offset: 0x00098A9F
		static UAnimationAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimationAsset");
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x0009A8B0 File Offset: 0x00098AB0
		protected UAnimationAsset() : this(BuiltinUtils.AllocNativeUObject(UAnimationAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x0009A8D8 File Offset: 0x00098AD8
		protected UAnimationAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003399 RID: 13209
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x0400339A RID: 13210
		internal static int __InterfaceOffset_IInterface_PreviewMeshProvider;

		// Token: 0x0400339B RID: 13211
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimationAsset";

		// Token: 0x0400339C RID: 13212
		private static IntPtr _ClassPtr;

		// Token: 0x0400339D RID: 13213
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400339E RID: 13214
		internal static int __PropertyOffset_Skeleton;

		// Token: 0x0400339F RID: 13215
		internal static int __PropertyOffset_MetaData;

		// Token: 0x040033A0 RID: 13216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMetaData> _MetaData;

		// Token: 0x040033A1 RID: 13217
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x040033A2 RID: 13218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;
	}
}
