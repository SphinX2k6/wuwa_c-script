using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018C0 RID: 6336
	[UnrealObjectPath("/Script/KuroGameplay.KuroAttachTargetAxisFilter")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FKuroAttachTargetAxisFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601769E RID: 95902 RVA: 0x00223C53 File Offset: 0x00221E53
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAttachTargetAxisFilter._ScriptStructPtr != 0) ? FKuroAttachTargetAxisFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroAttachTargetAxisFilter", ref FKuroAttachTargetAxisFilter._ScriptStructPtr);
		}

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x0601769F RID: 95903 RVA: 0x00223C77 File Offset: 0x00221E77
		// (set) Token: 0x060176A0 RID: 95904 RVA: 0x00223C87 File Offset: 0x00221E87
		public unsafe bool bIgnoreTargetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAttachTargetAxisFilter.__PropertyOffset_bIgnoreTargetX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAttachTargetAxisFilter.__PropertyOffset_bIgnoreTargetX) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x060176A1 RID: 95905 RVA: 0x00223C98 File Offset: 0x00221E98
		// (set) Token: 0x060176A2 RID: 95906 RVA: 0x00223CA8 File Offset: 0x00221EA8
		public unsafe bool bIgnoreTargetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAttachTargetAxisFilter.__PropertyOffset_bIgnoreTargetY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAttachTargetAxisFilter.__PropertyOffset_bIgnoreTargetY) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x060176A3 RID: 95907 RVA: 0x00223CB9 File Offset: 0x00221EB9
		// (set) Token: 0x060176A4 RID: 95908 RVA: 0x00223CC9 File Offset: 0x00221EC9
		public unsafe bool bIgnoreTargetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAttachTargetAxisFilter.__PropertyOffset_bIgnoreTargetZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAttachTargetAxisFilter.__PropertyOffset_bIgnoreTargetZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x060176A5 RID: 95909 RVA: 0x00223CDA File Offset: 0x00221EDA
		public FKuroAttachTargetAxisFilter()
		{
		}

		// Token: 0x060176A6 RID: 95910 RVA: 0x00223CE2 File Offset: 0x00221EE2
		public FKuroAttachTargetAxisFilter(bool bIgnoreTargetX, bool bIgnoreTargetY, bool bIgnoreTargetZ)
		{
			this.bIgnoreTargetX = bIgnoreTargetX;
			this.bIgnoreTargetY = bIgnoreTargetY;
			this.bIgnoreTargetZ = bIgnoreTargetZ;
		}

		// Token: 0x060176A7 RID: 95911 RVA: 0x00223CFF File Offset: 0x00221EFF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAttachTargetAxisFilter.StaticStruct();
		}

		// Token: 0x060176A8 RID: 95912 RVA: 0x00223D0B File Offset: 0x00221F0B
		[NullableContext(2)]
		public FKuroAttachTargetAxisFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060176A9 RID: 95913 RVA: 0x00223D15 File Offset: 0x00221F15
		public FKuroAttachTargetAxisFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060176AA RID: 95914 RVA: 0x00223D20 File Offset: 0x00221F20
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAttachTargetAxisFilter(Pointer, false, true);
		}

		// Token: 0x060176AB RID: 95915 RVA: 0x00223D2A File Offset: 0x00221F2A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAttachTargetAxisFilter(Pointer, MemoryOwner);
		}

		// Token: 0x0400CBBD RID: 52157
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroAttachTargetAxisFilter";

		// Token: 0x0400CBBE RID: 52158
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CBBF RID: 52159
		internal static int __PropertyOffset_bIgnoreTargetX;

		// Token: 0x0400CBC0 RID: 52160
		internal static int __PropertyOffset_bIgnoreTargetY;

		// Token: 0x0400CBC1 RID: 52161
		internal static int __PropertyOffset_bIgnoreTargetZ;
	}
}
