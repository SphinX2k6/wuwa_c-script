using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002538 RID: 9528
	[UnrealObjectPath("/Script/Niagara.NDCSingleDebugDrawSettings")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNDCSingleDebugDrawSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235E6 RID: 144870 RVA: 0x00344E62 File Offset: 0x00343062
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDCSingleDebugDrawSettings._ScriptStructPtr != 0) ? FNDCSingleDebugDrawSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDCSingleDebugDrawSettings", ref FNDCSingleDebugDrawSettings._ScriptStructPtr);
		}

		// Token: 0x170087F5 RID: 34805
		// (get) Token: 0x060235E7 RID: 144871 RVA: 0x00344E86 File Offset: 0x00343086
		// (set) Token: 0x060235E8 RID: 144872 RVA: 0x00344E9F File Offset: 0x0034309F
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNDCSingleDebugDrawSettings.__PropertyOffset_bEnabled) & FNDCSingleDebugDrawSettings.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNDCSingleDebugDrawSettings.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FNDCSingleDebugDrawSettings.__PropertyOffset_bEnabled) & ~FNDCSingleDebugDrawSettings.__PropertyMask_bEnabled) | (value ? FNDCSingleDebugDrawSettings.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x170087F6 RID: 34806
		// (get) Token: 0x060235E9 RID: 144873 RVA: 0x00344ECF File Offset: 0x003430CF
		// (set) Token: 0x060235EA RID: 144874 RVA: 0x00344EE8 File Offset: 0x003430E8
		public unsafe bool bShowSingleBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNDCSingleDebugDrawSettings.__PropertyOffset_bShowSingleBounds) & FNDCSingleDebugDrawSettings.__PropertyMask_bShowSingleBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNDCSingleDebugDrawSettings.__PropertyOffset_bShowSingleBounds) = ((*(base.NativePtr + (IntPtr)FNDCSingleDebugDrawSettings.__PropertyOffset_bShowSingleBounds) & ~FNDCSingleDebugDrawSettings.__PropertyMask_bShowSingleBounds) | (value ? FNDCSingleDebugDrawSettings.__PropertyMask_bShowSingleBounds : 0));
			}
		}

		// Token: 0x060235EB RID: 144875 RVA: 0x00344F18 File Offset: 0x00343118
		public FNDCSingleDebugDrawSettings()
		{
		}

		// Token: 0x060235EC RID: 144876 RVA: 0x00344F20 File Offset: 0x00343120
		public FNDCSingleDebugDrawSettings(bool bEnabled, bool bShowSingleBounds)
		{
			this.bEnabled = bEnabled;
			this.bShowSingleBounds = bShowSingleBounds;
		}

		// Token: 0x060235ED RID: 144877 RVA: 0x00344F36 File Offset: 0x00343136
		protected override IntPtr GetUStructPtr()
		{
			return FNDCSingleDebugDrawSettings.StaticStruct();
		}

		// Token: 0x060235EE RID: 144878 RVA: 0x00344F42 File Offset: 0x00343142
		[NullableContext(2)]
		public FNDCSingleDebugDrawSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060235EF RID: 144879 RVA: 0x00344F4C File Offset: 0x0034314C
		public FNDCSingleDebugDrawSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235F0 RID: 144880 RVA: 0x00344F57 File Offset: 0x00343157
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDCSingleDebugDrawSettings(Pointer, false, true);
		}

		// Token: 0x060235F1 RID: 144881 RVA: 0x00344F61 File Offset: 0x00343161
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDCSingleDebugDrawSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04012FBF RID: 77759
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NDCSingleDebugDrawSettings";

		// Token: 0x04012FC0 RID: 77760
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FC1 RID: 77761
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04012FC2 RID: 77762
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04012FC3 RID: 77763
		internal static int __PropertyOffset_bShowSingleBounds;

		// Token: 0x04012FC4 RID: 77764
		internal static byte __PropertyMask_bShowSingleBounds;
	}
}
