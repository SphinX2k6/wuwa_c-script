using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D3 RID: 1491
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_KalmanFloat")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_KalmanFloat : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600508A RID: 20618 RVA: 0x00076E7D File Offset: 0x0007507D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_KalmanFloat._ScriptStructPtr != 0) ? FRigUnit_KalmanFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_KalmanFloat", ref FRigUnit_KalmanFloat._ScriptStructPtr);
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x00076EA1 File Offset: 0x000750A1
		// (set) Token: 0x0600508C RID: 20620 RVA: 0x00076EB1 File Offset: 0x000750B1
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x00076EC2 File Offset: 0x000750C2
		// (set) Token: 0x0600508E RID: 20622 RVA: 0x00076ED2 File Offset: 0x000750D2
		public unsafe int BufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_BufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_BufferSize) = value;
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x00076EE3 File Offset: 0x000750E3
		// (set) Token: 0x06005090 RID: 20624 RVA: 0x00076EF3 File Offset: 0x000750F3
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06005091 RID: 20625 RVA: 0x00076F04 File Offset: 0x00075104
		// (set) Token: 0x06005092 RID: 20626 RVA: 0x00076F47 File Offset: 0x00075147
		public TArray<float> Buffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Buffer) == null)
				{
					result = (this._Buffer = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_Buffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buffer.CopyAssign(value);
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x00076F55 File Offset: 0x00075155
		// (set) Token: 0x06005094 RID: 20628 RVA: 0x00076F65 File Offset: 0x00075165
		public unsafe int LastInsertIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_LastInsertIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_KalmanFloat.__PropertyOffset_LastInsertIndex) = value;
			}
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00076F76 File Offset: 0x00075176
		public FRigUnit_KalmanFloat()
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00076F7E File Offset: 0x0007517E
		public FRigUnit_KalmanFloat(float Value, int BufferSize, float Result, TArray<float> Buffer, int LastInsertIndex)
		{
			this.Value = Value;
			this.BufferSize = BufferSize;
			this.Result = Result;
			this.Buffer = Buffer;
			this.LastInsertIndex = LastInsertIndex;
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00076FAB File Offset: 0x000751AB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_KalmanFloat.StaticStruct();
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x00076FB7 File Offset: 0x000751B7
		[NullableContext(2)]
		public FRigUnit_KalmanFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x00076FC1 File Offset: 0x000751C1
		public FRigUnit_KalmanFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x00076FCC File Offset: 0x000751CC
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_KalmanFloat(Pointer, false, true);
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x00076FD6 File Offset: 0x000751D6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_KalmanFloat(Pointer, MemoryOwner);
		}

		// Token: 0x040026DB RID: 9947
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_KalmanFloat";

		// Token: 0x040026DC RID: 9948
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026DD RID: 9949
		internal static int __PropertyOffset_Value;

		// Token: 0x040026DE RID: 9950
		internal static int __PropertyOffset_BufferSize;

		// Token: 0x040026DF RID: 9951
		internal static int __PropertyOffset_Result;

		// Token: 0x040026E0 RID: 9952
		internal static int __PropertyOffset_Buffer;

		// Token: 0x040026E1 RID: 9953
		[Nullable(2)]
		private TArray<float> _Buffer;

		// Token: 0x040026E2 RID: 9954
		internal static int __PropertyOffset_LastInsertIndex;
	}
}
