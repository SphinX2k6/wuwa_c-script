using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE0 RID: 3296
	[UnrealObjectPath("/Script/Engine.KuroAssetVersion")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FKuroAssetVersion : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AECA RID: 44746 RVA: 0x000F7F65 File Offset: 0x000F6165
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAssetVersion._ScriptStructPtr != 0) ? FKuroAssetVersion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroAssetVersion", ref FKuroAssetVersion._ScriptStructPtr);
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x000F7F89 File Offset: 0x000F6189
		public FKuroAssetVersion()
		{
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x000F7F91 File Offset: 0x000F6191
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAssetVersion.StaticStruct();
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x000F7F9D File Offset: 0x000F619D
		[NullableContext(2)]
		public FKuroAssetVersion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x000F7FA7 File Offset: 0x000F61A7
		public FKuroAssetVersion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AECF RID: 44751 RVA: 0x000F7FB2 File Offset: 0x000F61B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAssetVersion(Pointer, false, true);
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x000F7FBC File Offset: 0x000F61BC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAssetVersion(Pointer, MemoryOwner);
		}

		// Token: 0x04005B8E RID: 23438
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroAssetVersion";

		// Token: 0x04005B8F RID: 23439
		private static IntPtr _ScriptStructPtr;
	}
}
