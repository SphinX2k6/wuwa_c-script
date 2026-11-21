using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000301 RID: 769
	[UnrealObjectPath("/Script/KuroAnim.KuroSeparateCameraData")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroSeparateCameraData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052D8 RID: 21208 RVA: 0x00073D30 File Offset: 0x00071F30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSeparateCameraData._ScriptStructPtr != 0) ? FKuroSeparateCameraData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroSeparateCameraData", ref FKuroSeparateCameraData._ScriptStructPtr);
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060052D9 RID: 21209 RVA: 0x00073D54 File Offset: 0x00071F54
		// (set) Token: 0x060052DA RID: 21210 RVA: 0x00073D64 File Offset: 0x00071F64
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x00073D75 File Offset: 0x00071F75
		// (set) Token: 0x060052DC RID: 21212 RVA: 0x00073D85 File Offset: 0x00071F85
		public unsafe bool bEnableScissorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_bEnableScissorOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_bEnableScissorOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x060052DD RID: 21213 RVA: 0x00073D96 File Offset: 0x00071F96
		// (set) Token: 0x060052DE RID: 21214 RVA: 0x00073DAA File Offset: 0x00071FAA
		public unsafe FVector2D Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x060052DF RID: 21215 RVA: 0x00073DBF File Offset: 0x00071FBF
		// (set) Token: 0x060052E0 RID: 21216 RVA: 0x00073DD3 File Offset: 0x00071FD3
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSeparateCameraData.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00073DE8 File Offset: 0x00071FE8
		public FKuroSeparateCameraData()
		{
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00073DF0 File Offset: 0x00071FF0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSeparateCameraData.StaticStruct();
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00073DFC File Offset: 0x00071FFC
		[NullableContext(2)]
		public FKuroSeparateCameraData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00073E06 File Offset: 0x00072006
		public FKuroSeparateCameraData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00073E11 File Offset: 0x00072011
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSeparateCameraData(Pointer, false, true);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00073E1B File Offset: 0x0007201B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSeparateCameraData(Pointer, MemoryOwner);
		}

		// Token: 0x040021C7 RID: 8647
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroSeparateCameraData";

		// Token: 0x040021C8 RID: 8648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021C9 RID: 8649
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040021CA RID: 8650
		internal static int __PropertyOffset_bEnableScissorOffset;

		// Token: 0x040021CB RID: 8651
		internal static int __PropertyOffset_Location;

		// Token: 0x040021CC RID: 8652
		internal static int __PropertyOffset_Size;
	}
}
