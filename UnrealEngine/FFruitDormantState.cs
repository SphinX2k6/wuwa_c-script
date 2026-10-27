using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A94 RID: 6804
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FruitDormantState")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFruitDormantState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601918A RID: 102794 RVA: 0x00250DF9 File Offset: 0x0024EFF9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFruitDormantState._ScriptStructPtr != 0) ? FFruitDormantState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FruitDormantState", ref FFruitDormantState._ScriptStructPtr);
		}

		// Token: 0x170063B1 RID: 25521
		// (get) Token: 0x0601918B RID: 102795 RVA: 0x00250E1D File Offset: 0x0024F01D
		// (set) Token: 0x0601918C RID: 102796 RVA: 0x00250E31 File Offset: 0x0024F031
		public unsafe FVector LocalPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_LocalPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_LocalPos) = value;
			}
		}

		// Token: 0x170063B2 RID: 25522
		// (get) Token: 0x0601918D RID: 102797 RVA: 0x00250E46 File Offset: 0x0024F046
		// (set) Token: 0x0601918E RID: 102798 RVA: 0x00250E56 File Offset: 0x0024F056
		public unsafe float UniformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_UniformScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_UniformScale) = value;
			}
		}

		// Token: 0x170063B3 RID: 25523
		// (get) Token: 0x0601918F RID: 102799 RVA: 0x00250E67 File Offset: 0x0024F067
		// (set) Token: 0x06019190 RID: 102800 RVA: 0x00250E7B File Offset: 0x0024F07B
		public unsafe FVector PivotData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_PivotData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_PivotData) = value;
			}
		}

		// Token: 0x170063B4 RID: 25524
		// (get) Token: 0x06019191 RID: 102801 RVA: 0x00250E90 File Offset: 0x0024F090
		// (set) Token: 0x06019192 RID: 102802 RVA: 0x00250EA0 File Offset: 0x0024F0A0
		public unsafe bool bPicked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_bPicked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFruitDormantState.__PropertyOffset_bPicked) = (value ? 1 : 0);
			}
		}

		// Token: 0x06019193 RID: 102803 RVA: 0x00250EB1 File Offset: 0x0024F0B1
		public FFruitDormantState()
		{
		}

		// Token: 0x06019194 RID: 102804 RVA: 0x00250EB9 File Offset: 0x0024F0B9
		public FFruitDormantState(FVector LocalPos, float UniformScale, FVector PivotData, bool bPicked)
		{
			this.LocalPos = LocalPos;
			this.UniformScale = UniformScale;
			this.PivotData = PivotData;
			this.bPicked = bPicked;
		}

		// Token: 0x06019195 RID: 102805 RVA: 0x00250EDE File Offset: 0x0024F0DE
		protected override IntPtr GetUStructPtr()
		{
			return FFruitDormantState.StaticStruct();
		}

		// Token: 0x06019196 RID: 102806 RVA: 0x00250EEA File Offset: 0x0024F0EA
		[NullableContext(2)]
		public FFruitDormantState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019197 RID: 102807 RVA: 0x00250EF4 File Offset: 0x0024F0F4
		public FFruitDormantState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019198 RID: 102808 RVA: 0x00250EFF File Offset: 0x0024F0FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFruitDormantState(Pointer, false, true);
		}

		// Token: 0x06019199 RID: 102809 RVA: 0x00250F09 File Offset: 0x0024F109
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFruitDormantState(Pointer, MemoryOwner);
		}

		// Token: 0x0400DAD2 RID: 56018
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FruitDormantState";

		// Token: 0x0400DAD3 RID: 56019
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAD4 RID: 56020
		internal static int __PropertyOffset_LocalPos;

		// Token: 0x0400DAD5 RID: 56021
		internal static int __PropertyOffset_UniformScale;

		// Token: 0x0400DAD6 RID: 56022
		internal static int __PropertyOffset_PivotData;

		// Token: 0x0400DAD7 RID: 56023
		internal static int __PropertyOffset_bPicked;
	}
}
