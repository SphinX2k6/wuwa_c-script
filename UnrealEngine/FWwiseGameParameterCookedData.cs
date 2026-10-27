using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A84 RID: 10884
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseGameParameterCookedData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseGameParameterCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028201 RID: 164353 RVA: 0x003D101C File Offset: 0x003CF21C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseGameParameterCookedData._ScriptStructPtr != 0) ? FWwiseGameParameterCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseGameParameterCookedData", ref FWwiseGameParameterCookedData._ScriptStructPtr);
		}

		// Token: 0x1700992C RID: 39212
		// (get) Token: 0x06028202 RID: 164354 RVA: 0x003D1040 File Offset: 0x003CF240
		// (set) Token: 0x06028203 RID: 164355 RVA: 0x003D1050 File Offset: 0x003CF250
		public unsafe int ShortId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseGameParameterCookedData.__PropertyOffset_ShortId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGameParameterCookedData.__PropertyOffset_ShortId) = value;
			}
		}

		// Token: 0x1700992D RID: 39213
		// (get) Token: 0x06028204 RID: 164356 RVA: 0x003D1061 File Offset: 0x003CF261
		// (set) Token: 0x06028205 RID: 164357 RVA: 0x003D1075 File Offset: 0x003CF275
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseGameParameterCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGameParameterCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x06028206 RID: 164358 RVA: 0x003D108A File Offset: 0x003CF28A
		public FWwiseGameParameterCookedData()
		{
		}

		// Token: 0x06028207 RID: 164359 RVA: 0x003D1092 File Offset: 0x003CF292
		public FWwiseGameParameterCookedData(int ShortId, FName DebugName)
		{
			this.ShortId = ShortId;
			this.DebugName = DebugName;
		}

		// Token: 0x06028208 RID: 164360 RVA: 0x003D10A8 File Offset: 0x003CF2A8
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseGameParameterCookedData.StaticStruct();
		}

		// Token: 0x06028209 RID: 164361 RVA: 0x003D10B4 File Offset: 0x003CF2B4
		[NullableContext(2)]
		public FWwiseGameParameterCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602820A RID: 164362 RVA: 0x003D10BE File Offset: 0x003CF2BE
		public FWwiseGameParameterCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602820B RID: 164363 RVA: 0x003D10C9 File Offset: 0x003CF2C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseGameParameterCookedData(Pointer, false, true);
		}

		// Token: 0x0602820C RID: 164364 RVA: 0x003D10D3 File Offset: 0x003CF2D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseGameParameterCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016041 RID: 90177
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseGameParameterCookedData";

		// Token: 0x04016042 RID: 90178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016043 RID: 90179
		internal static int __PropertyOffset_ShortId;

		// Token: 0x04016044 RID: 90180
		internal static int __PropertyOffset_DebugName;
	}
}
