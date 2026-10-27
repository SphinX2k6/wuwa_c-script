using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200166E RID: 5742
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_InputData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroQuadrupedIK_InputData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014D02 RID: 85250 RVA: 0x001E9A2D File Offset: 0x001E7C2D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroQuadrupedIK_InputData._ScriptStructPtr != 0) ? FKuroQuadrupedIK_InputData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroQuadrupedIK_InputData", ref FKuroQuadrupedIK_InputData._ScriptStructPtr);
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x06014D03 RID: 85251 RVA: 0x001E9A51 File Offset: 0x001E7C51
		// (set) Token: 0x06014D04 RID: 85252 RVA: 0x001E9A65 File Offset: 0x001E7C65
		public unsafe FName Spine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Spine);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Spine) = value;
			}
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x06014D05 RID: 85253 RVA: 0x001E9A7A File Offset: 0x001E7C7A
		// (set) Token: 0x06014D06 RID: 85254 RVA: 0x001E9A8E File Offset: 0x001E7C8E
		public unsafe FName Pelvis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Pelvis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Pelvis) = value;
			}
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x06014D07 RID: 85255 RVA: 0x001E9AA3 File Offset: 0x001E7CA3
		// (set) Token: 0x06014D08 RID: 85256 RVA: 0x001E9AB7 File Offset: 0x001E7CB7
		public unsafe FName Head
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Head);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Head) = value;
			}
		}

		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x06014D09 RID: 85257 RVA: 0x001E9ACC File Offset: 0x001E7CCC
		// (set) Token: 0x06014D0A RID: 85258 RVA: 0x001E9AE0 File Offset: 0x001E7CE0
		public unsafe FName Tail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Tail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_Tail) = value;
			}
		}

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x06014D0B RID: 85259 RVA: 0x001E9AF8 File Offset: 0x001E7CF8
		// (set) Token: 0x06014D0C RID: 85260 RVA: 0x001E9B3B File Offset: 0x001E7D3B
		public TArray<FKuroQuadrupedIK_FootData> FeetDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroQuadrupedIK_FootData> result;
				if ((result = this._FeetDatas) == null)
				{
					result = (this._FeetDatas = new TArray<FKuroQuadrupedIK_FootData>(base.NativePtr + (IntPtr)FKuroQuadrupedIK_InputData.__PropertyOffset_FeetDatas, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FeetDatas.CopyAssign(value);
			}
		}

		// Token: 0x06014D0D RID: 85261 RVA: 0x001E9B49 File Offset: 0x001E7D49
		public FKuroQuadrupedIK_InputData()
		{
		}

		// Token: 0x06014D0E RID: 85262 RVA: 0x001E9B51 File Offset: 0x001E7D51
		public FKuroQuadrupedIK_InputData(FName Spine, FName Pelvis, FName Head, FName Tail, TArray<FKuroQuadrupedIK_FootData> FeetDatas)
		{
			this.Spine = Spine;
			this.Pelvis = Pelvis;
			this.Head = Head;
			this.Tail = Tail;
			this.FeetDatas = FeetDatas;
		}

		// Token: 0x06014D0F RID: 85263 RVA: 0x001E9B7E File Offset: 0x001E7D7E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroQuadrupedIK_InputData.StaticStruct();
		}

		// Token: 0x06014D10 RID: 85264 RVA: 0x001E9B8A File Offset: 0x001E7D8A
		[NullableContext(2)]
		public FKuroQuadrupedIK_InputData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014D11 RID: 85265 RVA: 0x001E9B94 File Offset: 0x001E7D94
		public FKuroQuadrupedIK_InputData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014D12 RID: 85266 RVA: 0x001E9B9F File Offset: 0x001E7D9F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroQuadrupedIK_InputData(Pointer, false, true);
		}

		// Token: 0x06014D13 RID: 85267 RVA: 0x001E9BA9 File Offset: 0x001E7DA9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroQuadrupedIK_InputData(Pointer, MemoryOwner);
		}

		// Token: 0x0400B583 RID: 46467
		public const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_InputData";

		// Token: 0x0400B584 RID: 46468
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B585 RID: 46469
		internal static int __PropertyOffset_Spine;

		// Token: 0x0400B586 RID: 46470
		internal static int __PropertyOffset_Pelvis;

		// Token: 0x0400B587 RID: 46471
		internal static int __PropertyOffset_Head;

		// Token: 0x0400B588 RID: 46472
		internal static int __PropertyOffset_Tail;

		// Token: 0x0400B589 RID: 46473
		internal static int __PropertyOffset_FeetDatas;

		// Token: 0x0400B58A RID: 46474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroQuadrupedIK_FootData> _FeetDatas;
	}
}
