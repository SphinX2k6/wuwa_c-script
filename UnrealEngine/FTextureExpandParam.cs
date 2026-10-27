using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001807 RID: 6151
	[UnrealObjectPath("/Script/KuroDynamicAtlas.TextureExpandParam")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTextureExpandParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C36 RID: 93238 RVA: 0x0021392F File Offset: 0x00211B2F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureExpandParam._ScriptStructPtr != 0) ? FTextureExpandParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicAtlas.TextureExpandParam", ref FTextureExpandParam._ScriptStructPtr);
		}

		// Token: 0x06016C37 RID: 93239 RVA: 0x00213953 File Offset: 0x00211B53
		public FTextureExpandParam()
		{
		}

		// Token: 0x06016C38 RID: 93240 RVA: 0x0021395B File Offset: 0x00211B5B
		protected override IntPtr GetUStructPtr()
		{
			return FTextureExpandParam.StaticStruct();
		}

		// Token: 0x06016C39 RID: 93241 RVA: 0x00213967 File Offset: 0x00211B67
		[NullableContext(2)]
		public FTextureExpandParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C3A RID: 93242 RVA: 0x00213971 File Offset: 0x00211B71
		public FTextureExpandParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C3B RID: 93243 RVA: 0x0021397C File Offset: 0x00211B7C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureExpandParam(Pointer, false, true);
		}

		// Token: 0x06016C3C RID: 93244 RVA: 0x00213986 File Offset: 0x00211B86
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureExpandParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5A8 RID: 50600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicAtlas.TextureExpandParam";

		// Token: 0x0400C5A9 RID: 50601
		private static IntPtr _ScriptStructPtr;
	}
}
