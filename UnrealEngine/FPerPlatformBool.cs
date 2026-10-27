using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FD7 RID: 4055
	[UnrealObjectPath("/Script/Engine.PerPlatformBool")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FPerPlatformBool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DB08 RID: 56072 RVA: 0x00142D87 File Offset: 0x00140F87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerPlatformBool._ScriptStructPtr != 0) ? FPerPlatformBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerPlatformBool", ref FPerPlatformBool._ScriptStructPtr);
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600DB09 RID: 56073 RVA: 0x00142DAB File Offset: 0x00140FAB
		// (set) Token: 0x0600DB0A RID: 56074 RVA: 0x00142DBB File Offset: 0x00140FBB
		public unsafe bool Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerPlatformBool.__PropertyOffset_Default) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerPlatformBool.__PropertyOffset_Default) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600DB0B RID: 56075 RVA: 0x00142DCC File Offset: 0x00140FCC
		public FPerPlatformBool()
		{
		}

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00142DD4 File Offset: 0x00140FD4
		[NullableContext(1)]
		public FPerPlatformBool(bool Default, TMap<FName, bool> PerPlatform)
		{
			this.Default = Default;
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x00142DE3 File Offset: 0x00140FE3
		protected override IntPtr GetUStructPtr()
		{
			return FPerPlatformBool.StaticStruct();
		}

		// Token: 0x0600DB0E RID: 56078 RVA: 0x00142DEF File Offset: 0x00140FEF
		[NullableContext(2)]
		public FPerPlatformBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x00142DF9 File Offset: 0x00140FF9
		public FPerPlatformBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB10 RID: 56080 RVA: 0x00142E04 File Offset: 0x00141004
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerPlatformBool(Pointer, false, true);
		}

		// Token: 0x0600DB11 RID: 56081 RVA: 0x00142E0E File Offset: 0x0014100E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerPlatformBool(Pointer, MemoryOwner);
		}

		// Token: 0x04007690 RID: 30352
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PerPlatformBool";

		// Token: 0x04007691 RID: 30353
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007692 RID: 30354
		internal static int __PropertyOffset_Default;
	}
}
