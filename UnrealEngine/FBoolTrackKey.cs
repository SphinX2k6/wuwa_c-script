using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008E5 RID: 2277
	[UnrealObjectPath("/Script/Engine.BoolTrackKey")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FBoolTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007CE9 RID: 31977 RVA: 0x000B31C9 File Offset: 0x000B13C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoolTrackKey._ScriptStructPtr != 0) ? FBoolTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoolTrackKey", ref FBoolTrackKey._ScriptStructPtr);
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06007CEA RID: 31978 RVA: 0x000B31ED File Offset: 0x000B13ED
		// (set) Token: 0x06007CEB RID: 31979 RVA: 0x000B31FD File Offset: 0x000B13FD
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoolTrackKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoolTrackKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x000B320E File Offset: 0x000B140E
		// (set) Token: 0x06007CED RID: 31981 RVA: 0x000B3227 File Offset: 0x000B1427
		public unsafe bool Value
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBoolTrackKey.__PropertyOffset_Value) & FBoolTrackKey.__PropertyMask_Value) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBoolTrackKey.__PropertyOffset_Value) = ((*(base.NativePtr + (IntPtr)FBoolTrackKey.__PropertyOffset_Value) & ~FBoolTrackKey.__PropertyMask_Value) | (value ? FBoolTrackKey.__PropertyMask_Value : 0));
			}
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x000B3257 File Offset: 0x000B1457
		public FBoolTrackKey()
		{
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x000B325F File Offset: 0x000B145F
		public FBoolTrackKey(float Time, bool Value)
		{
			this.Time = Time;
			this.Value = Value;
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x000B3275 File Offset: 0x000B1475
		protected override IntPtr GetUStructPtr()
		{
			return FBoolTrackKey.StaticStruct();
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x000B3281 File Offset: 0x000B1481
		[NullableContext(2)]
		public FBoolTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x000B328B File Offset: 0x000B148B
		public FBoolTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x000B3296 File Offset: 0x000B1496
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoolTrackKey(Pointer, false, true);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x000B32A0 File Offset: 0x000B14A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoolTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x04003BDF RID: 15327
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoolTrackKey";

		// Token: 0x04003BE0 RID: 15328
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BE1 RID: 15329
		internal static int __PropertyOffset_Time;

		// Token: 0x04003BE2 RID: 15330
		internal static int __PropertyOffset_Value;

		// Token: 0x04003BE3 RID: 15331
		internal static byte __PropertyMask_Value;
	}
}
