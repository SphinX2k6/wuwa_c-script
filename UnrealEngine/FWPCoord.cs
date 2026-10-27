using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C3A RID: 7226
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.WPCoord")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FWPCoord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C084 RID: 114820 RVA: 0x00294248 File Offset: 0x00292448
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWPCoord._ScriptStructPtr != 0) ? FWPCoord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.WPCoord", ref FWPCoord._ScriptStructPtr);
		}

		// Token: 0x17007157 RID: 29015
		// (get) Token: 0x0601C085 RID: 114821 RVA: 0x0029426C File Offset: 0x0029246C
		// (set) Token: 0x0601C086 RID: 114822 RVA: 0x0029427C File Offset: 0x0029247C
		public unsafe int X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWPCoord.__PropertyOffset_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWPCoord.__PropertyOffset_X) = value;
			}
		}

		// Token: 0x17007158 RID: 29016
		// (get) Token: 0x0601C087 RID: 114823 RVA: 0x0029428D File Offset: 0x0029248D
		// (set) Token: 0x0601C088 RID: 114824 RVA: 0x0029429D File Offset: 0x0029249D
		public unsafe int Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWPCoord.__PropertyOffset_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWPCoord.__PropertyOffset_Y) = value;
			}
		}

		// Token: 0x0601C089 RID: 114825 RVA: 0x002942AE File Offset: 0x002924AE
		public FWPCoord()
		{
		}

		// Token: 0x0601C08A RID: 114826 RVA: 0x002942B6 File Offset: 0x002924B6
		public FWPCoord(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		// Token: 0x0601C08B RID: 114827 RVA: 0x002942CC File Offset: 0x002924CC
		protected override IntPtr GetUStructPtr()
		{
			return FWPCoord.StaticStruct();
		}

		// Token: 0x0601C08C RID: 114828 RVA: 0x002942D8 File Offset: 0x002924D8
		[NullableContext(2)]
		public FWPCoord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C08D RID: 114829 RVA: 0x002942E2 File Offset: 0x002924E2
		public FWPCoord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C08E RID: 114830 RVA: 0x002942ED File Offset: 0x002924ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWPCoord(Pointer, false, true);
		}

		// Token: 0x0601C08F RID: 114831 RVA: 0x002942F7 File Offset: 0x002924F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWPCoord(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0EB RID: 61675
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.WPCoord";

		// Token: 0x0400F0EC RID: 61676
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0ED RID: 61677
		internal static int __PropertyOffset_X;

		// Token: 0x0400F0EE RID: 61678
		internal static int __PropertyOffset_Y;
	}
}
