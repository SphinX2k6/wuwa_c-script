using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE9 RID: 3305
	[UnrealObjectPath("/Script/Engine.KuroEffectModelBaseFolderCheckConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroEffectModelBaseFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF5D RID: 44893 RVA: 0x000F8BF5 File Offset: 0x000F6DF5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectModelBaseFolderCheckConfig._ScriptStructPtr != 0) ? FKuroEffectModelBaseFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroEffectModelBaseFolderCheckConfig", ref FKuroEffectModelBaseFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x0600AF5E RID: 44894 RVA: 0x000F8C19 File Offset: 0x000F6E19
		// (set) Token: 0x0600AF5F RID: 44895 RVA: 0x000F8C32 File Offset: 0x000F6E32
		public unsafe bool bUiScenePrimitive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bUiScenePrimitive) & FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bUiScenePrimitive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bUiScenePrimitive) = ((*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bUiScenePrimitive) & ~FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bUiScenePrimitive) | (value ? FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bUiScenePrimitive : 0));
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x0600AF60 RID: 44896 RVA: 0x000F8C62 File Offset: 0x000F6E62
		// (set) Token: 0x0600AF61 RID: 44897 RVA: 0x000F8C7B File Offset: 0x000F6E7B
		public unsafe bool bAutoPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bAutoPlay) & FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bAutoPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bAutoPlay) = ((*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bAutoPlay) & ~FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bAutoPlay) | (value ? FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bAutoPlay : 0));
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x0600AF62 RID: 44898 RVA: 0x000F8CAB File Offset: 0x000F6EAB
		// (set) Token: 0x0600AF63 RID: 44899 RVA: 0x000F8CC4 File Offset: 0x000F6EC4
		public unsafe bool bAutoDestroy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bAutoDestroy) & FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bAutoDestroy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bAutoDestroy) = ((*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_bAutoDestroy) & ~FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bAutoDestroy) | (value ? FKuroEffectModelBaseFolderCheckConfig.__PropertyMask_bAutoDestroy : 0));
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x0600AF64 RID: 44900 RVA: 0x000F8CF4 File Offset: 0x000F6EF4
		// (set) Token: 0x0600AF65 RID: 44901 RVA: 0x000F8D04 File Offset: 0x000F6F04
		public unsafe int PCTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_PCTriangles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_PCTriangles) = value;
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0600AF66 RID: 44902 RVA: 0x000F8D15 File Offset: 0x000F6F15
		// (set) Token: 0x0600AF67 RID: 44903 RVA: 0x000F8D25 File Offset: 0x000F6F25
		public unsafe float PCTexNums
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_PCTexNums);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_PCTexNums) = value;
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x000F8D36 File Offset: 0x000F6F36
		// (set) Token: 0x0600AF69 RID: 44905 RVA: 0x000F8D46 File Offset: 0x000F6F46
		public unsafe int MobileTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_MobileTriangles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_MobileTriangles) = value;
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0600AF6A RID: 44906 RVA: 0x000F8D57 File Offset: 0x000F6F57
		// (set) Token: 0x0600AF6B RID: 44907 RVA: 0x000F8D67 File Offset: 0x000F6F67
		public unsafe float MobileTexNums
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_MobileTexNums);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_MobileTexNums) = value;
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600AF6C RID: 44908 RVA: 0x000F8D78 File Offset: 0x000F6F78
		// (set) Token: 0x0600AF6D RID: 44909 RVA: 0x000F8D88 File Offset: 0x000F6F88
		public unsafe int PCMipsNums
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_PCMipsNums);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_PCMipsNums) = value;
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x000F8D99 File Offset: 0x000F6F99
		// (set) Token: 0x0600AF6F RID: 44911 RVA: 0x000F8DA9 File Offset: 0x000F6FA9
		public unsafe int MobileMipsNums
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_MobileMipsNums);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectModelBaseFolderCheckConfig.__PropertyOffset_MobileMipsNums) = value;
			}
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x000F8DBA File Offset: 0x000F6FBA
		public FKuroEffectModelBaseFolderCheckConfig()
		{
		}

		// Token: 0x0600AF71 RID: 44913 RVA: 0x000F8DC4 File Offset: 0x000F6FC4
		[NullableContext(1)]
		public FKuroEffectModelBaseFolderCheckConfig(bool bUiScenePrimitive, bool bAutoPlay, bool bAutoDestroy, int PCTriangles, float PCTexNums, int MobileTriangles, float MobileTexNums, int PCMipsNums, int MobileMipsNums, string Regex, int MatchingPriority)
		{
			this.bUiScenePrimitive = bUiScenePrimitive;
			this.bAutoPlay = bAutoPlay;
			this.bAutoDestroy = bAutoDestroy;
			this.PCTriangles = PCTriangles;
			this.PCTexNums = PCTexNums;
			this.MobileTriangles = MobileTriangles;
			this.MobileTexNums = MobileTexNums;
			this.PCMipsNums = PCMipsNums;
			this.MobileMipsNums = MobileMipsNums;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AF72 RID: 44914 RVA: 0x000F8E2C File Offset: 0x000F702C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectModelBaseFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AF73 RID: 44915 RVA: 0x000F8E38 File Offset: 0x000F7038
		[NullableContext(2)]
		public FKuroEffectModelBaseFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF74 RID: 44916 RVA: 0x000F8E42 File Offset: 0x000F7042
		public FKuroEffectModelBaseFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF75 RID: 44917 RVA: 0x000F8E4D File Offset: 0x000F704D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectModelBaseFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AF76 RID: 44918 RVA: 0x000F8E57 File Offset: 0x000F7057
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectModelBaseFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005BD5 RID: 23509
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroEffectModelBaseFolderCheckConfig";

		// Token: 0x04005BD6 RID: 23510
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BD7 RID: 23511
		internal static int __PropertyOffset_bUiScenePrimitive;

		// Token: 0x04005BD8 RID: 23512
		internal static byte __PropertyMask_bUiScenePrimitive;

		// Token: 0x04005BD9 RID: 23513
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x04005BDA RID: 23514
		internal static byte __PropertyMask_bAutoPlay;

		// Token: 0x04005BDB RID: 23515
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x04005BDC RID: 23516
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x04005BDD RID: 23517
		internal static int __PropertyOffset_PCTriangles;

		// Token: 0x04005BDE RID: 23518
		internal static int __PropertyOffset_PCTexNums;

		// Token: 0x04005BDF RID: 23519
		internal static int __PropertyOffset_MobileTriangles;

		// Token: 0x04005BE0 RID: 23520
		internal static int __PropertyOffset_MobileTexNums;

		// Token: 0x04005BE1 RID: 23521
		internal static int __PropertyOffset_PCMipsNums;

		// Token: 0x04005BE2 RID: 23522
		internal static int __PropertyOffset_MobileMipsNums;
	}
}
