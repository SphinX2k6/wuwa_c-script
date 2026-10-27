using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D1E RID: 3358
	[UnrealObjectPath("/Script/Engine.LayerActorStats")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLayerActorStats : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B402 RID: 46082 RVA: 0x00100B86 File Offset: 0x000FED86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLayerActorStats._ScriptStructPtr != 0) ? FLayerActorStats._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LayerActorStats", ref FLayerActorStats._ScriptStructPtr);
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600B403 RID: 46083 RVA: 0x00100BAA File Offset: 0x000FEDAA
		// (set) Token: 0x0600B404 RID: 46084 RVA: 0x00100BBE File Offset: 0x000FEDBE
		public unsafe UClassStackOnlyPtr Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerActorStats.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLayerActorStats.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600B405 RID: 46085 RVA: 0x00100BD3 File Offset: 0x000FEDD3
		// (set) Token: 0x0600B406 RID: 46086 RVA: 0x00100BE3 File Offset: 0x000FEDE3
		public unsafe int Total
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerActorStats.__PropertyOffset_Total);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLayerActorStats.__PropertyOffset_Total) = value;
			}
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x00100BF4 File Offset: 0x000FEDF4
		public FLayerActorStats()
		{
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x00100BFC File Offset: 0x000FEDFC
		public FLayerActorStats(UClassStackOnlyPtr Type, int Total)
		{
			this.Type = Type;
			this.Total = Total;
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x00100C12 File Offset: 0x000FEE12
		protected override IntPtr GetUStructPtr()
		{
			return FLayerActorStats.StaticStruct();
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x00100C1E File Offset: 0x000FEE1E
		[NullableContext(2)]
		public FLayerActorStats(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x00100C28 File Offset: 0x000FEE28
		public FLayerActorStats(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x00100C33 File Offset: 0x000FEE33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLayerActorStats(Pointer, false, true);
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x00100C3D File Offset: 0x000FEE3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLayerActorStats(Pointer, MemoryOwner);
		}

		// Token: 0x04005E9E RID: 24222
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LayerActorStats";

		// Token: 0x04005E9F RID: 24223
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005EA0 RID: 24224
		internal static int __PropertyOffset_Type;

		// Token: 0x04005EA1 RID: 24225
		internal static int __PropertyOffset_Total;
	}
}
