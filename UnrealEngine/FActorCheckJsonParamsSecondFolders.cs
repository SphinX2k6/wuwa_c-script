using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007AE RID: 1966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorCheckJsonParamsSecondFolders")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FActorCheckJsonParamsSecondFolders : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060068E4 RID: 26852 RVA: 0x00096936 File Offset: 0x00094B36
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorCheckJsonParamsSecondFolders._ScriptStructPtr != 0) ? FActorCheckJsonParamsSecondFolders._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorCheckJsonParamsSecondFolders", ref FActorCheckJsonParamsSecondFolders._ScriptStructPtr);
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060068E5 RID: 26853 RVA: 0x0009695A File Offset: 0x00094B5A
		// (set) Token: 0x060068E6 RID: 26854 RVA: 0x0009696E File Offset: 0x00094B6E
		public unsafe string SecondName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_SecondName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_SecondName)), value);
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x00096983 File Offset: 0x00094B83
		// (set) Token: 0x060068E8 RID: 26856 RVA: 0x00096997 File Offset: 0x00094B97
		public unsafe string Regex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_Regex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_Regex)), value);
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x000969AC File Offset: 0x00094BAC
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x000969C5 File Offset: 0x00094BC5
		public unsafe bool EnableSpecifiedClass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_EnableSpecifiedClass) & FActorCheckJsonParamsSecondFolders.__PropertyMask_EnableSpecifiedClass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_EnableSpecifiedClass) = ((*(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_EnableSpecifiedClass) & ~FActorCheckJsonParamsSecondFolders.__PropertyMask_EnableSpecifiedClass) | (value ? FActorCheckJsonParamsSecondFolders.__PropertyMask_EnableSpecifiedClass : 0));
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x000969F8 File Offset: 0x00094BF8
		// (set) Token: 0x060068EC RID: 26860 RVA: 0x00096A3B File Offset: 0x00094C3B
		public TArray<string> SpecifiedClassName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SpecifiedClassName) == null)
				{
					result = (this._SpecifiedClassName = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_SpecifiedClassName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecifiedClassName.CopyAssign(value);
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x060068ED RID: 26861 RVA: 0x00096A49 File Offset: 0x00094C49
		// (set) Token: 0x060068EE RID: 26862 RVA: 0x00096A5D File Offset: 0x00094C5D
		public unsafe string Grid
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_Grid)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_Grid)), value);
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x060068EF RID: 26863 RVA: 0x00096A74 File Offset: 0x00094C74
		// (set) Token: 0x060068F0 RID: 26864 RVA: 0x00096AB7 File Offset: 0x00094CB7
		public TArray<string> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x060068F1 RID: 26865 RVA: 0x00096AC8 File Offset: 0x00094CC8
		// (set) Token: 0x060068F2 RID: 26866 RVA: 0x00096B0B File Offset: 0x00094D0B
		public TArray<string> OverrideGridPattern
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OverrideGridPattern) == null)
				{
					result = (this._OverrideGridPattern = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_OverrideGridPattern, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideGridPattern.CopyAssign(value);
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x00096B1C File Offset: 0x00094D1C
		// (set) Token: 0x060068F4 RID: 26868 RVA: 0x00096B5F File Offset: 0x00094D5F
		public TArray<string> OverrideGrid
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OverrideGrid) == null)
				{
					result = (this._OverrideGrid = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_OverrideGrid, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideGrid.CopyAssign(value);
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x060068F5 RID: 26869 RVA: 0x00096B70 File Offset: 0x00094D70
		// (set) Token: 0x060068F6 RID: 26870 RVA: 0x00096BB3 File Offset: 0x00094DB3
		public TArray<string> AdditionalDataLayerPattern
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AdditionalDataLayerPattern) == null)
				{
					result = (this._AdditionalDataLayerPattern = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_AdditionalDataLayerPattern, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditionalDataLayerPattern.CopyAssign(value);
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x060068F7 RID: 26871 RVA: 0x00096BC4 File Offset: 0x00094DC4
		// (set) Token: 0x060068F8 RID: 26872 RVA: 0x00096C07 File Offset: 0x00094E07
		public TArray<string> AdditionalDataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AdditionalDataLayers) == null)
				{
					result = (this._AdditionalDataLayers = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_AdditionalDataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditionalDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x00096C15 File Offset: 0x00094E15
		// (set) Token: 0x060068FA RID: 26874 RVA: 0x00096C2E File Offset: 0x00094E2E
		public unsafe bool bWithoutMapAreaFolder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_bWithoutMapAreaFolder) & FActorCheckJsonParamsSecondFolders.__PropertyMask_bWithoutMapAreaFolder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_bWithoutMapAreaFolder) = ((*(base.NativePtr + (IntPtr)FActorCheckJsonParamsSecondFolders.__PropertyOffset_bWithoutMapAreaFolder) & ~FActorCheckJsonParamsSecondFolders.__PropertyMask_bWithoutMapAreaFolder) | (value ? FActorCheckJsonParamsSecondFolders.__PropertyMask_bWithoutMapAreaFolder : 0));
			}
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x00096C5E File Offset: 0x00094E5E
		public FActorCheckJsonParamsSecondFolders()
		{
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x00096C68 File Offset: 0x00094E68
		public FActorCheckJsonParamsSecondFolders(string SecondName, string Regex, bool EnableSpecifiedClass, TArray<string> SpecifiedClassName, string Grid, TArray<string> DataLayers, TArray<string> OverrideGridPattern, TArray<string> OverrideGrid, TArray<string> AdditionalDataLayerPattern, TArray<string> AdditionalDataLayers, bool bWithoutMapAreaFolder)
		{
			this.SecondName = SecondName;
			this.Regex = Regex;
			this.EnableSpecifiedClass = EnableSpecifiedClass;
			this.SpecifiedClassName = SpecifiedClassName;
			this.Grid = Grid;
			this.DataLayers = DataLayers;
			this.OverrideGridPattern = OverrideGridPattern;
			this.OverrideGrid = OverrideGrid;
			this.AdditionalDataLayerPattern = AdditionalDataLayerPattern;
			this.AdditionalDataLayers = AdditionalDataLayers;
			this.bWithoutMapAreaFolder = bWithoutMapAreaFolder;
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00096CD0 File Offset: 0x00094ED0
		protected override IntPtr GetUStructPtr()
		{
			return FActorCheckJsonParamsSecondFolders.StaticStruct();
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00096CDC File Offset: 0x00094EDC
		[NullableContext(2)]
		public FActorCheckJsonParamsSecondFolders(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x00096CE6 File Offset: 0x00094EE6
		public FActorCheckJsonParamsSecondFolders(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x00096CF1 File Offset: 0x00094EF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorCheckJsonParamsSecondFolders(Pointer, false, true);
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x00096CFB File Offset: 0x00094EFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorCheckJsonParamsSecondFolders(Pointer, MemoryOwner);
		}

		// Token: 0x0400329A RID: 12954
		public const string __ObjectPath = "/Script/Engine.ActorCheckJsonParamsSecondFolders";

		// Token: 0x0400329B RID: 12955
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400329C RID: 12956
		internal static int __PropertyOffset_SecondName;

		// Token: 0x0400329D RID: 12957
		internal static int __PropertyOffset_Regex;

		// Token: 0x0400329E RID: 12958
		internal static int __PropertyOffset_EnableSpecifiedClass;

		// Token: 0x0400329F RID: 12959
		internal static byte __PropertyMask_EnableSpecifiedClass;

		// Token: 0x040032A0 RID: 12960
		internal static int __PropertyOffset_SpecifiedClassName;

		// Token: 0x040032A1 RID: 12961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SpecifiedClassName;

		// Token: 0x040032A2 RID: 12962
		internal static int __PropertyOffset_Grid;

		// Token: 0x040032A3 RID: 12963
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x040032A4 RID: 12964
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DataLayers;

		// Token: 0x040032A5 RID: 12965
		internal static int __PropertyOffset_OverrideGridPattern;

		// Token: 0x040032A6 RID: 12966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OverrideGridPattern;

		// Token: 0x040032A7 RID: 12967
		internal static int __PropertyOffset_OverrideGrid;

		// Token: 0x040032A8 RID: 12968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OverrideGrid;

		// Token: 0x040032A9 RID: 12969
		internal static int __PropertyOffset_AdditionalDataLayerPattern;

		// Token: 0x040032AA RID: 12970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AdditionalDataLayerPattern;

		// Token: 0x040032AB RID: 12971
		internal static int __PropertyOffset_AdditionalDataLayers;

		// Token: 0x040032AC RID: 12972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AdditionalDataLayers;

		// Token: 0x040032AD RID: 12973
		internal static int __PropertyOffset_bWithoutMapAreaFolder;

		// Token: 0x040032AE RID: 12974
		internal static byte __PropertyMask_bWithoutMapAreaFolder;
	}
}
