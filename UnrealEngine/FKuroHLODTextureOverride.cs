using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F49 RID: 8009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroWorldPartition.KuroHLODTextureOverride")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroHLODTextureOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E766 RID: 124774 RVA: 0x002D48EA File Offset: 0x002D2AEA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHLODTextureOverride._ScriptStructPtr != 0) ? FKuroHLODTextureOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroWorldPartition.KuroHLODTextureOverride", ref FKuroHLODTextureOverride._ScriptStructPtr);
		}

		// Token: 0x17007925 RID: 31013
		// (get) Token: 0x0601E767 RID: 124775 RVA: 0x002D490E File Offset: 0x002D2B0E
		// (set) Token: 0x0601E768 RID: 124776 RVA: 0x002D4922 File Offset: 0x002D2B22
		public unsafe string NameContains
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHLODTextureOverride.__PropertyOffset_NameContains)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHLODTextureOverride.__PropertyOffset_NameContains)), value);
			}
		}

		// Token: 0x17007926 RID: 31014
		// (get) Token: 0x0601E769 RID: 124777 RVA: 0x002D4937 File Offset: 0x002D2B37
		// (set) Token: 0x0601E76A RID: 124778 RVA: 0x002D494B File Offset: 0x002D2B4B
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextureCompressionQuality> CompressionQuality
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHLODTextureOverride.__PropertyOffset_CompressionQuality);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHLODTextureOverride.__PropertyOffset_CompressionQuality) = value;
			}
		}

		// Token: 0x17007927 RID: 31015
		// (get) Token: 0x0601E76B RID: 124779 RVA: 0x002D4960 File Offset: 0x002D2B60
		// (set) Token: 0x0601E76C RID: 124780 RVA: 0x002D49A3 File Offset: 0x002D2BA3
		public TMap<FName, float> DownscalePerPlatform
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._DownscalePerPlatform) == null)
				{
					result = (this._DownscalePerPlatform = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroHLODTextureOverride.__PropertyOffset_DownscalePerPlatform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DownscalePerPlatform.CopyAssign(value);
			}
		}

		// Token: 0x17007928 RID: 31016
		// (get) Token: 0x0601E76D RID: 124781 RVA: 0x002D49B1 File Offset: 0x002D2BB1
		// (set) Token: 0x0601E76E RID: 124782 RVA: 0x002D49C1 File Offset: 0x002D2BC1
		public unsafe int MaxTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHLODTextureOverride.__PropertyOffset_MaxTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHLODTextureOverride.__PropertyOffset_MaxTextureSize) = value;
			}
		}

		// Token: 0x0601E76F RID: 124783 RVA: 0x002D49D2 File Offset: 0x002D2BD2
		public FKuroHLODTextureOverride()
		{
		}

		// Token: 0x0601E770 RID: 124784 RVA: 0x002D49DA File Offset: 0x002D2BDA
		public FKuroHLODTextureOverride(string NameContains, [Nullable(0)] TEnumAsByte<ETextureCompressionQuality> CompressionQuality, TMap<FName, float> DownscalePerPlatform, int MaxTextureSize)
		{
			this.NameContains = NameContains;
			this.CompressionQuality = CompressionQuality;
			this.DownscalePerPlatform = DownscalePerPlatform;
			this.MaxTextureSize = MaxTextureSize;
		}

		// Token: 0x0601E771 RID: 124785 RVA: 0x002D49FF File Offset: 0x002D2BFF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHLODTextureOverride.StaticStruct();
		}

		// Token: 0x0601E772 RID: 124786 RVA: 0x002D4A0B File Offset: 0x002D2C0B
		[NullableContext(2)]
		public FKuroHLODTextureOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E773 RID: 124787 RVA: 0x002D4A15 File Offset: 0x002D2C15
		public FKuroHLODTextureOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E774 RID: 124788 RVA: 0x002D4A20 File Offset: 0x002D2C20
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHLODTextureOverride(Pointer, false, true);
		}

		// Token: 0x0601E775 RID: 124789 RVA: 0x002D4A2A File Offset: 0x002D2C2A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHLODTextureOverride(Pointer, MemoryOwner);
		}

		// Token: 0x040106EE RID: 67310
		public const string __ObjectPath = "/Script/KuroWorldPartition.KuroHLODTextureOverride";

		// Token: 0x040106EF RID: 67311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040106F0 RID: 67312
		internal static int __PropertyOffset_NameContains;

		// Token: 0x040106F1 RID: 67313
		internal static int __PropertyOffset_CompressionQuality;

		// Token: 0x040106F2 RID: 67314
		internal static int __PropertyOffset_DownscalePerPlatform;

		// Token: 0x040106F3 RID: 67315
		[Nullable(2)]
		private TMap<FName, float> _DownscalePerPlatform;

		// Token: 0x040106F4 RID: 67316
		internal static int __PropertyOffset_MaxTextureSize;
	}
}
