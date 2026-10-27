using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D06 RID: 3334
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroRenderTarget2DFolderCheckConfig")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroRenderTarget2DFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B17A RID: 45434 RVA: 0x000FBEA2 File Offset: 0x000FA0A2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRenderTarget2DFolderCheckConfig._ScriptStructPtr != 0) ? FKuroRenderTarget2DFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroRenderTarget2DFolderCheckConfig", ref FKuroRenderTarget2DFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0600B17B RID: 45435 RVA: 0x000FBEC6 File Offset: 0x000FA0C6
		// (set) Token: 0x0600B17C RID: 45436 RVA: 0x000FBED6 File Offset: 0x000FA0D6
		public unsafe int MaxSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_MaxSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_MaxSizeX) = value;
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0600B17D RID: 45437 RVA: 0x000FBEE7 File Offset: 0x000FA0E7
		// (set) Token: 0x0600B17E RID: 45438 RVA: 0x000FBEF7 File Offset: 0x000FA0F7
		public unsafe int MaxSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_MaxSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_MaxSizeY) = value;
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600B17F RID: 45439 RVA: 0x000FBF08 File Offset: 0x000FA108
		// (set) Token: 0x0600B180 RID: 45440 RVA: 0x000FBF4B File Offset: 0x000FA14B
		public TArray<string> SizePlatforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SizePlatforms) == null)
				{
					result = (this._SizePlatforms = new TArray<string>(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_SizePlatforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SizePlatforms.CopyAssign(value);
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600B181 RID: 45441 RVA: 0x000FBF5C File Offset: 0x000FA15C
		// (set) Token: 0x0600B182 RID: 45442 RVA: 0x000FBF9F File Offset: 0x000FA19F
		public TArray<int> PlatformSizeX
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PlatformSizeX) == null)
				{
					result = (this._PlatformSizeX = new TArray<int>(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_PlatformSizeX, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformSizeX.CopyAssign(value);
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600B183 RID: 45443 RVA: 0x000FBFB0 File Offset: 0x000FA1B0
		// (set) Token: 0x0600B184 RID: 45444 RVA: 0x000FBFF3 File Offset: 0x000FA1F3
		public TArray<int> PlatformSizeY
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PlatformSizeY) == null)
				{
					result = (this._PlatformSizeY = new TArray<int>(base.NativePtr + (IntPtr)FKuroRenderTarget2DFolderCheckConfig.__PropertyOffset_PlatformSizeY, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformSizeY.CopyAssign(value);
			}
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x000FC001 File Offset: 0x000FA201
		public FKuroRenderTarget2DFolderCheckConfig()
		{
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x000FC009 File Offset: 0x000FA209
		public FKuroRenderTarget2DFolderCheckConfig(int MaxSizeX, int MaxSizeY, TArray<string> SizePlatforms, TArray<int> PlatformSizeX, TArray<int> PlatformSizeY, string Regex, int MatchingPriority)
		{
			this.MaxSizeX = MaxSizeX;
			this.MaxSizeY = MaxSizeY;
			this.SizePlatforms = SizePlatforms;
			this.PlatformSizeX = PlatformSizeX;
			this.PlatformSizeY = PlatformSizeY;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x000FC046 File Offset: 0x000FA246
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRenderTarget2DFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x000FC052 File Offset: 0x000FA252
		[NullableContext(2)]
		public FKuroRenderTarget2DFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x000FC05C File Offset: 0x000FA25C
		public FKuroRenderTarget2DFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x000FC067 File Offset: 0x000FA267
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRenderTarget2DFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x000FC071 File Offset: 0x000FA271
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRenderTarget2DFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005CEE RID: 23790
		public new const string __ObjectPath = "/Script/Engine.KuroRenderTarget2DFolderCheckConfig";

		// Token: 0x04005CEF RID: 23791
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CF0 RID: 23792
		internal static int __PropertyOffset_MaxSizeX;

		// Token: 0x04005CF1 RID: 23793
		internal static int __PropertyOffset_MaxSizeY;

		// Token: 0x04005CF2 RID: 23794
		internal static int __PropertyOffset_SizePlatforms;

		// Token: 0x04005CF3 RID: 23795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SizePlatforms;

		// Token: 0x04005CF4 RID: 23796
		internal static int __PropertyOffset_PlatformSizeX;

		// Token: 0x04005CF5 RID: 23797
		[Nullable(2)]
		private TArray<int> _PlatformSizeX;

		// Token: 0x04005CF6 RID: 23798
		internal static int __PropertyOffset_PlatformSizeY;

		// Token: 0x04005CF7 RID: 23799
		[Nullable(2)]
		private TArray<int> _PlatformSizeY;
	}
}
