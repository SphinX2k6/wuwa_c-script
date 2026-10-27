using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013AE RID: 5038
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.PredictionKey")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPredictionKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127BE RID: 75710 RVA: 0x001B2C74 File Offset: 0x001B0E74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictionKey._ScriptStructPtr != 0) ? FPredictionKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.PredictionKey", ref FPredictionKey._ScriptStructPtr);
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x060127BF RID: 75711 RVA: 0x001B2C98 File Offset: 0x001B0E98
		// (set) Token: 0x060127C0 RID: 75712 RVA: 0x001B2CAC File Offset: 0x001B0EAC
		[Nullable(2)]
		public unsafe UPackageMap PredictiveConnection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPackageMap>(base.NativePtr / (IntPtr)sizeof(void*) + FPredictionKey.__PropertyOffset_PredictiveConnection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPredictionKey.__PropertyOffset_PredictiveConnection, value);
			}
		}

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x060127C1 RID: 75713 RVA: 0x001B2CC1 File Offset: 0x001B0EC1
		// (set) Token: 0x060127C2 RID: 75714 RVA: 0x001B2CD1 File Offset: 0x001B0ED1
		public unsafe short Current
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_Current);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_Current) = value;
			}
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x060127C3 RID: 75715 RVA: 0x001B2CE2 File Offset: 0x001B0EE2
		// (set) Token: 0x060127C4 RID: 75716 RVA: 0x001B2CF2 File Offset: 0x001B0EF2
		public unsafe short Base
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_Base);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_Base) = value;
			}
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x060127C5 RID: 75717 RVA: 0x001B2D03 File Offset: 0x001B0F03
		// (set) Token: 0x060127C6 RID: 75718 RVA: 0x001B2D13 File Offset: 0x001B0F13
		public unsafe bool bIsStale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_bIsStale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_bIsStale) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x060127C7 RID: 75719 RVA: 0x001B2D24 File Offset: 0x001B0F24
		// (set) Token: 0x060127C8 RID: 75720 RVA: 0x001B2D34 File Offset: 0x001B0F34
		public unsafe bool bIsServerInitiated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_bIsServerInitiated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictionKey.__PropertyOffset_bIsServerInitiated) = (value ? 1 : 0);
			}
		}

		// Token: 0x060127C9 RID: 75721 RVA: 0x001B2D45 File Offset: 0x001B0F45
		public FPredictionKey()
		{
		}

		// Token: 0x060127CA RID: 75722 RVA: 0x001B2D4D File Offset: 0x001B0F4D
		[NullableContext(1)]
		public FPredictionKey(UPackageMap PredictiveConnection, short Current, short Base, bool bIsStale, bool bIsServerInitiated)
		{
			this.PredictiveConnection = PredictiveConnection;
			this.Current = Current;
			this.Base = Base;
			this.bIsStale = bIsStale;
			this.bIsServerInitiated = bIsServerInitiated;
		}

		// Token: 0x060127CB RID: 75723 RVA: 0x001B2D7A File Offset: 0x001B0F7A
		protected override IntPtr GetUStructPtr()
		{
			return FPredictionKey.StaticStruct();
		}

		// Token: 0x060127CC RID: 75724 RVA: 0x001B2D86 File Offset: 0x001B0F86
		[NullableContext(2)]
		public FPredictionKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127CD RID: 75725 RVA: 0x001B2D90 File Offset: 0x001B0F90
		public FPredictionKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127CE RID: 75726 RVA: 0x001B2D9B File Offset: 0x001B0F9B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictionKey(Pointer, false, true);
		}

		// Token: 0x060127CF RID: 75727 RVA: 0x001B2DA5 File Offset: 0x001B0FA5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictionKey(Pointer, MemoryOwner);
		}

		// Token: 0x04009E41 RID: 40513
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.PredictionKey";

		// Token: 0x04009E42 RID: 40514
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E43 RID: 40515
		internal static int __PropertyOffset_PredictiveConnection;

		// Token: 0x04009E44 RID: 40516
		internal static int __PropertyOffset_Current;

		// Token: 0x04009E45 RID: 40517
		internal static int __PropertyOffset_Base;

		// Token: 0x04009E46 RID: 40518
		internal static int __PropertyOffset_bIsStale;

		// Token: 0x04009E47 RID: 40519
		internal static int __PropertyOffset_bIsServerInitiated;
	}
}
