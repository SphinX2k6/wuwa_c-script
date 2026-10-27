using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200265F RID: 9823
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ProceduralMeshComponent.ProcMeshVertex")]
	[UnrealStructLayout(108, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class FProcMeshVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024828 RID: 149544 RVA: 0x00360E29 File Offset: 0x0035F029
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProcMeshVertex._ScriptStructPtr != 0) ? FProcMeshVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ProceduralMeshComponent.ProcMeshVertex", ref FProcMeshVertex._ScriptStructPtr);
		}

		// Token: 0x17008CB3 RID: 36019
		// (get) Token: 0x06024829 RID: 149545 RVA: 0x00360E4D File Offset: 0x0035F04D
		// (set) Token: 0x0602482A RID: 149546 RVA: 0x00360E61 File Offset: 0x0035F061
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17008CB4 RID: 36020
		// (get) Token: 0x0602482B RID: 149547 RVA: 0x00360E76 File Offset: 0x0035F076
		// (set) Token: 0x0602482C RID: 149548 RVA: 0x00360E8A File Offset: 0x0035F08A
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17008CB5 RID: 36021
		// (get) Token: 0x0602482D RID: 149549 RVA: 0x00360EA0 File Offset: 0x0035F0A0
		// (set) Token: 0x0602482E RID: 149550 RVA: 0x00360EE3 File Offset: 0x0035F0E3
		public FProcMeshTangent Tangent
		{
			get
			{
				base.FastCheckIsValid();
				FProcMeshTangent result;
				if ((result = this._Tangent) == null)
				{
					result = (this._Tangent = new FProcMeshTangent(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Tangent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FProcMeshTangent.StaticStruct(), base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Tangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008CB6 RID: 36022
		// (get) Token: 0x0602482F RID: 149551 RVA: 0x00360F04 File Offset: 0x0035F104
		// (set) Token: 0x06024830 RID: 149552 RVA: 0x00360F18 File Offset: 0x0035F118
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17008CB7 RID: 36023
		// (get) Token: 0x06024831 RID: 149553 RVA: 0x00360F2D File Offset: 0x0035F12D
		// (set) Token: 0x06024832 RID: 149554 RVA: 0x00360F41 File Offset: 0x0035F141
		public unsafe FVector2D UV0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV0) = value;
			}
		}

		// Token: 0x17008CB8 RID: 36024
		// (get) Token: 0x06024833 RID: 149555 RVA: 0x00360F56 File Offset: 0x0035F156
		// (set) Token: 0x06024834 RID: 149556 RVA: 0x00360F6A File Offset: 0x0035F16A
		public unsafe FVector2D UV1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV1) = value;
			}
		}

		// Token: 0x17008CB9 RID: 36025
		// (get) Token: 0x06024835 RID: 149557 RVA: 0x00360F7F File Offset: 0x0035F17F
		// (set) Token: 0x06024836 RID: 149558 RVA: 0x00360F93 File Offset: 0x0035F193
		public unsafe FVector2D UV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV2) = value;
			}
		}

		// Token: 0x17008CBA RID: 36026
		// (get) Token: 0x06024837 RID: 149559 RVA: 0x00360FA8 File Offset: 0x0035F1A8
		// (set) Token: 0x06024838 RID: 149560 RVA: 0x00360FBC File Offset: 0x0035F1BC
		public unsafe FVector2D UV3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV3) = value;
			}
		}

		// Token: 0x17008CBB RID: 36027
		// (get) Token: 0x06024839 RID: 149561 RVA: 0x00360FD1 File Offset: 0x0035F1D1
		// (set) Token: 0x0602483A RID: 149562 RVA: 0x00360FE5 File Offset: 0x0035F1E5
		public unsafe FVector2D UV4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV4) = value;
			}
		}

		// Token: 0x17008CBC RID: 36028
		// (get) Token: 0x0602483B RID: 149563 RVA: 0x00360FFA File Offset: 0x0035F1FA
		// (set) Token: 0x0602483C RID: 149564 RVA: 0x0036100E File Offset: 0x0035F20E
		public unsafe FVector2D UV5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV5) = value;
			}
		}

		// Token: 0x17008CBD RID: 36029
		// (get) Token: 0x0602483D RID: 149565 RVA: 0x00361023 File Offset: 0x0035F223
		// (set) Token: 0x0602483E RID: 149566 RVA: 0x00361037 File Offset: 0x0035F237
		public unsafe FVector2D UV6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV6) = value;
			}
		}

		// Token: 0x17008CBE RID: 36030
		// (get) Token: 0x0602483F RID: 149567 RVA: 0x0036104C File Offset: 0x0035F24C
		// (set) Token: 0x06024840 RID: 149568 RVA: 0x00361060 File Offset: 0x0035F260
		public unsafe FVector2D UV7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshVertex.__PropertyOffset_UV7) = value;
			}
		}

		// Token: 0x06024841 RID: 149569 RVA: 0x00361075 File Offset: 0x0035F275
		public FProcMeshVertex()
		{
		}

		// Token: 0x06024842 RID: 149570 RVA: 0x00361080 File Offset: 0x0035F280
		public FProcMeshVertex(FVector Position, FVector Normal, FProcMeshTangent Tangent, FColor Color, FVector2D UV0, FVector2D UV1, FVector2D UV2, FVector2D UV3, FVector2D UV4, FVector2D UV5, FVector2D UV6, FVector2D UV7)
		{
			this.Position = Position;
			this.Normal = Normal;
			this.Tangent = Tangent;
			this.Color = Color;
			this.UV0 = UV0;
			this.UV1 = UV1;
			this.UV2 = UV2;
			this.UV3 = UV3;
			this.UV4 = UV4;
			this.UV5 = UV5;
			this.UV6 = UV6;
			this.UV7 = UV7;
		}

		// Token: 0x06024843 RID: 149571 RVA: 0x003610F0 File Offset: 0x0035F2F0
		protected override IntPtr GetUStructPtr()
		{
			return FProcMeshVertex.StaticStruct();
		}

		// Token: 0x06024844 RID: 149572 RVA: 0x003610FC File Offset: 0x0035F2FC
		[NullableContext(2)]
		public FProcMeshVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024845 RID: 149573 RVA: 0x00361106 File Offset: 0x0035F306
		public FProcMeshVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024846 RID: 149574 RVA: 0x00361111 File Offset: 0x0035F311
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProcMeshVertex(Pointer, false, true);
		}

		// Token: 0x06024847 RID: 149575 RVA: 0x0036111B File Offset: 0x0035F31B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProcMeshVertex(Pointer, MemoryOwner);
		}

		// Token: 0x040139C6 RID: 80326
		public const string __ObjectPath = "/Script/ProceduralMeshComponent.ProcMeshVertex";

		// Token: 0x040139C7 RID: 80327
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040139C8 RID: 80328
		internal static int __PropertyOffset_Position;

		// Token: 0x040139C9 RID: 80329
		internal static int __PropertyOffset_Normal;

		// Token: 0x040139CA RID: 80330
		internal static int __PropertyOffset_Tangent;

		// Token: 0x040139CB RID: 80331
		[Nullable(2)]
		private FProcMeshTangent _Tangent;

		// Token: 0x040139CC RID: 80332
		internal static int __PropertyOffset_Color;

		// Token: 0x040139CD RID: 80333
		internal static int __PropertyOffset_UV0;

		// Token: 0x040139CE RID: 80334
		internal static int __PropertyOffset_UV1;

		// Token: 0x040139CF RID: 80335
		internal static int __PropertyOffset_UV2;

		// Token: 0x040139D0 RID: 80336
		internal static int __PropertyOffset_UV3;

		// Token: 0x040139D1 RID: 80337
		internal static int __PropertyOffset_UV4;

		// Token: 0x040139D2 RID: 80338
		internal static int __PropertyOffset_UV5;

		// Token: 0x040139D3 RID: 80339
		internal static int __PropertyOffset_UV6;

		// Token: 0x040139D4 RID: 80340
		internal static int __PropertyOffset_UV7;
	}
}
