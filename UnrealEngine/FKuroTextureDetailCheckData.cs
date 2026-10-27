using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D13 RID: 3347
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroTextureDetailCheckData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroTextureDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B30F RID: 45839 RVA: 0x000FF1B4 File Offset: 0x000FD3B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTextureDetailCheckData._ScriptStructPtr != 0) ? FKuroTextureDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroTextureDetailCheckData", ref FKuroTextureDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x000FF1D8 File Offset: 0x000FD3D8
		// (set) Token: 0x0600B311 RID: 45841 RVA: 0x000FF1EC File Offset: 0x000FD3EC
		public unsafe string tex_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureDetailCheckData.__PropertyOffset_tex_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureDetailCheckData.__PropertyOffset_tex_path)), value);
			}
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x000FF201 File Offset: 0x000FD401
		public FKuroTextureDetailCheckData()
		{
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x000FF209 File Offset: 0x000FD409
		public FKuroTextureDetailCheckData(string tex_path)
		{
			this.tex_path = tex_path;
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x000FF218 File Offset: 0x000FD418
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTextureDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x000FF224 File Offset: 0x000FD424
		[NullableContext(2)]
		public FKuroTextureDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x000FF22E File Offset: 0x000FD42E
		public FKuroTextureDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x000FF239 File Offset: 0x000FD439
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTextureDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x000FF243 File Offset: 0x000FD443
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTextureDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005E07 RID: 24071
		public const string __ObjectPath = "/Script/Engine.KuroTextureDetailCheckData";

		// Token: 0x04005E08 RID: 24072
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005E09 RID: 24073
		internal static int __PropertyOffset_tex_path;
	}
}
