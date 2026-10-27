using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A24 RID: 6692
	[UnrealObjectPath("/Script/KuroPointCloud.KPCWDynamicPointSocketInfo")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKPCWDynamicPointSocketInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018C0E RID: 101390 RVA: 0x0024945A File Offset: 0x0024765A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKPCWDynamicPointSocketInfo._ScriptStructPtr != 0) ? FKPCWDynamicPointSocketInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KPCWDynamicPointSocketInfo", ref FKPCWDynamicPointSocketInfo._ScriptStructPtr);
		}

		// Token: 0x1700621F RID: 25119
		// (get) Token: 0x06018C0F RID: 101391 RVA: 0x0024947E File Offset: 0x0024767E
		// (set) Token: 0x06018C10 RID: 101392 RVA: 0x00249492 File Offset: 0x00247692
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWDynamicPointSocketInfo.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWDynamicPointSocketInfo.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17006220 RID: 25120
		// (get) Token: 0x06018C11 RID: 101393 RVA: 0x002494A7 File Offset: 0x002476A7
		// (set) Token: 0x06018C12 RID: 101394 RVA: 0x002494BB File Offset: 0x002476BB
		public unsafe FTransform SocketSpaceTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWDynamicPointSocketInfo.__PropertyOffset_SocketSpaceTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWDynamicPointSocketInfo.__PropertyOffset_SocketSpaceTransform) = value;
			}
		}

		// Token: 0x06018C13 RID: 101395 RVA: 0x002494D0 File Offset: 0x002476D0
		public FKPCWDynamicPointSocketInfo()
		{
		}

		// Token: 0x06018C14 RID: 101396 RVA: 0x002494D8 File Offset: 0x002476D8
		public FKPCWDynamicPointSocketInfo(FName SocketName, FTransform SocketSpaceTransform)
		{
			this.SocketName = SocketName;
			this.SocketSpaceTransform = SocketSpaceTransform;
		}

		// Token: 0x06018C15 RID: 101397 RVA: 0x002494EE File Offset: 0x002476EE
		protected override IntPtr GetUStructPtr()
		{
			return FKPCWDynamicPointSocketInfo.StaticStruct();
		}

		// Token: 0x06018C16 RID: 101398 RVA: 0x002494FA File Offset: 0x002476FA
		[NullableContext(2)]
		public FKPCWDynamicPointSocketInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018C17 RID: 101399 RVA: 0x00249504 File Offset: 0x00247704
		public FKPCWDynamicPointSocketInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018C18 RID: 101400 RVA: 0x0024950F File Offset: 0x0024770F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKPCWDynamicPointSocketInfo(Pointer, false, true);
		}

		// Token: 0x06018C19 RID: 101401 RVA: 0x00249519 File Offset: 0x00247719
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKPCWDynamicPointSocketInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400D628 RID: 54824
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPointCloud.KPCWDynamicPointSocketInfo";

		// Token: 0x0400D629 RID: 54825
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D62A RID: 54826
		internal static int __PropertyOffset_SocketName;

		// Token: 0x0400D62B RID: 54827
		internal static int __PropertyOffset_SocketSpaceTransform;
	}
}
