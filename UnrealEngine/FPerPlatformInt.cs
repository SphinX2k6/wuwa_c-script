using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FD9 RID: 4057
	[UnrealObjectPath("/Script/Engine.PerPlatformInt")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FPerPlatformInt : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DB1C RID: 56092 RVA: 0x00142EA7 File Offset: 0x001410A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerPlatformInt._ScriptStructPtr != 0) ? FPerPlatformInt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerPlatformInt", ref FPerPlatformInt._ScriptStructPtr);
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600DB1D RID: 56093 RVA: 0x00142ECB File Offset: 0x001410CB
		// (set) Token: 0x0600DB1E RID: 56094 RVA: 0x00142EDB File Offset: 0x001410DB
		public unsafe int Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerPlatformInt.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerPlatformInt.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00142EEC File Offset: 0x001410EC
		public FPerPlatformInt()
		{
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00142EF4 File Offset: 0x001410F4
		[NullableContext(1)]
		public FPerPlatformInt(int Default, TMap<FName, int> PerPlatform)
		{
			this.Default = Default;
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x00142F03 File Offset: 0x00141103
		protected override IntPtr GetUStructPtr()
		{
			return FPerPlatformInt.StaticStruct();
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x00142F0F File Offset: 0x0014110F
		[NullableContext(2)]
		public FPerPlatformInt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x00142F19 File Offset: 0x00141119
		public FPerPlatformInt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB24 RID: 56100 RVA: 0x00142F24 File Offset: 0x00141124
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerPlatformInt(Pointer, false, true);
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00142F2E File Offset: 0x0014112E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerPlatformInt(Pointer, MemoryOwner);
		}

		// Token: 0x04007696 RID: 30358
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PerPlatformInt";

		// Token: 0x04007697 RID: 30359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007698 RID: 30360
		internal static int __PropertyOffset_Default;
	}
}
