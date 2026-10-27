using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001001 RID: 4097
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlatformInterfaceDelegateResult")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPlatformInterfaceDelegateResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DDDC RID: 56796 RVA: 0x00146DBC File Offset: 0x00144FBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlatformInterfaceDelegateResult._ScriptStructPtr != 0) ? FPlatformInterfaceDelegateResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PlatformInterfaceDelegateResult", ref FPlatformInterfaceDelegateResult._ScriptStructPtr);
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600DDDD RID: 56797 RVA: 0x00146DE0 File Offset: 0x00144FE0
		// (set) Token: 0x0600DDDE RID: 56798 RVA: 0x00146DF0 File Offset: 0x00144FF0
		public unsafe bool bSuccessful
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformInterfaceDelegateResult.__PropertyOffset_bSuccessful) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformInterfaceDelegateResult.__PropertyOffset_bSuccessful) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600DDDF RID: 56799 RVA: 0x00146E04 File Offset: 0x00145004
		// (set) Token: 0x0600DDE0 RID: 56800 RVA: 0x00146E47 File Offset: 0x00145047
		public FPlatformInterfaceData Data
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformInterfaceData result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new FPlatformInterfaceData(base.NativePtr + (IntPtr)FPlatformInterfaceDelegateResult.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPlatformInterfaceData.StaticStruct(), base.NativePtr + (IntPtr)FPlatformInterfaceDelegateResult.__PropertyOffset_Data, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600DDE1 RID: 56801 RVA: 0x00146E68 File Offset: 0x00145068
		public FPlatformInterfaceDelegateResult()
		{
		}

		// Token: 0x0600DDE2 RID: 56802 RVA: 0x00146E70 File Offset: 0x00145070
		public FPlatformInterfaceDelegateResult(bool bSuccessful, FPlatformInterfaceData Data)
		{
			this.bSuccessful = bSuccessful;
			this.Data = Data;
		}

		// Token: 0x0600DDE3 RID: 56803 RVA: 0x00146E86 File Offset: 0x00145086
		protected override IntPtr GetUStructPtr()
		{
			return FPlatformInterfaceDelegateResult.StaticStruct();
		}

		// Token: 0x0600DDE4 RID: 56804 RVA: 0x00146E92 File Offset: 0x00145092
		[NullableContext(2)]
		public FPlatformInterfaceDelegateResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x00146E9C File Offset: 0x0014509C
		public FPlatformInterfaceDelegateResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x00146EA7 File Offset: 0x001450A7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlatformInterfaceDelegateResult(Pointer, false, true);
		}

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x00146EB1 File Offset: 0x001450B1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlatformInterfaceDelegateResult(Pointer, MemoryOwner);
		}

		// Token: 0x040077F1 RID: 30705
		public const string __ObjectPath = "/Script/Engine.PlatformInterfaceDelegateResult";

		// Token: 0x040077F2 RID: 30706
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040077F3 RID: 30707
		internal static int __PropertyOffset_bSuccessful;

		// Token: 0x040077F4 RID: 30708
		internal static int __PropertyOffset_Data;

		// Token: 0x040077F5 RID: 30709
		[Nullable(2)]
		private FPlatformInterfaceData _Data;
	}
}
