using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ABD RID: 6845
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroChangeMaterialsTextures")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroChangeMaterialsTextures : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601962D RID: 103981 RVA: 0x0025830A File Offset: 0x0025650A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroChangeMaterialsTextures._ClassPtr;
		}

		// Token: 0x0601962E RID: 103982 RVA: 0x00258318 File Offset: 0x00256518
		public UKuroChangeMaterialsTextures() : this(BuiltinUtils.AllocNativeUObject(UKuroChangeMaterialsTextures.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601962F RID: 103983 RVA: 0x00258340 File Offset: 0x00256540
		public UKuroChangeMaterialsTextures(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroChangeMaterialsTextures.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006551 RID: 25937
		// (get) Token: 0x06019630 RID: 103984 RVA: 0x00258373 File Offset: 0x00256573
		// (set) Token: 0x06019631 RID: 103985 RVA: 0x00258387 File Offset: 0x00256587
		public unsafe string SkeletalMeshName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_SkeletalMeshName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_SkeletalMeshName)), value);
			}
		}

		// Token: 0x17006552 RID: 25938
		// (get) Token: 0x06019632 RID: 103986 RVA: 0x0025839C File Offset: 0x0025659C
		// (set) Token: 0x06019633 RID: 103987 RVA: 0x002583B0 File Offset: 0x002565B0
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17006553 RID: 25939
		// (get) Token: 0x06019634 RID: 103988 RVA: 0x002583C8 File Offset: 0x002565C8
		// (set) Token: 0x06019635 RID: 103989 RVA: 0x00258401 File Offset: 0x00256601
		public TArray<TSoftObjectPtr<UTexture2D>> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UTexture2D>> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TArray<TSoftObjectPtr<UTexture2D>>(base.NativePtr + (IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_Textures, this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x06019636 RID: 103990 RVA: 0x0025840F File Offset: 0x0025660F
		static UKuroChangeMaterialsTextures()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeMaterialsTextures");
		}

		// Token: 0x06019637 RID: 103991 RVA: 0x0025841D File Offset: 0x0025661D
		protected UKuroChangeMaterialsTextures(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD56 RID: 56662
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeMaterialsTextures";

		// Token: 0x0400DD57 RID: 56663
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD58 RID: 56664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DD59 RID: 56665
		internal static int __PropertyOffset_SkeletalMeshName;

		// Token: 0x0400DD5A RID: 56666
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400DD5B RID: 56667
		internal static int __PropertyOffset_Textures;

		// Token: 0x0400DD5C RID: 56668
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UTexture2D>> _Textures;
	}
}
