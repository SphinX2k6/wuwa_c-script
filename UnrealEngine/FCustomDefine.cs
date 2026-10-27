using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200098A RID: 2442
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomDefine")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCustomDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008A06 RID: 35334 RVA: 0x000C5B15 File Offset: 0x000C3D15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomDefine._ScriptStructPtr != 0) ? FCustomDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomDefine", ref FCustomDefine._ScriptStructPtr);
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06008A07 RID: 35335 RVA: 0x000C5B39 File Offset: 0x000C3D39
		// (set) Token: 0x06008A08 RID: 35336 RVA: 0x000C5B4D File Offset: 0x000C3D4D
		public unsafe string DefineName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCustomDefine.__PropertyOffset_DefineName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCustomDefine.__PropertyOffset_DefineName)), value);
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x000C5B62 File Offset: 0x000C3D62
		// (set) Token: 0x06008A0A RID: 35338 RVA: 0x000C5B76 File Offset: 0x000C3D76
		public unsafe string DefineValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCustomDefine.__PropertyOffset_DefineValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCustomDefine.__PropertyOffset_DefineValue)), value);
			}
		}

		// Token: 0x06008A0B RID: 35339 RVA: 0x000C5B8B File Offset: 0x000C3D8B
		public FCustomDefine()
		{
		}

		// Token: 0x06008A0C RID: 35340 RVA: 0x000C5B93 File Offset: 0x000C3D93
		public FCustomDefine(string DefineName, string DefineValue)
		{
			this.DefineName = DefineName;
			this.DefineValue = DefineValue;
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x000C5BA9 File Offset: 0x000C3DA9
		protected override IntPtr GetUStructPtr()
		{
			return FCustomDefine.StaticStruct();
		}

		// Token: 0x06008A0E RID: 35342 RVA: 0x000C5BB5 File Offset: 0x000C3DB5
		[NullableContext(2)]
		public FCustomDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A0F RID: 35343 RVA: 0x000C5BBF File Offset: 0x000C3DBF
		public FCustomDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x000C5BCA File Offset: 0x000C3DCA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomDefine(Pointer, false, true);
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x000C5BD4 File Offset: 0x000C3DD4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomDefine(Pointer, MemoryOwner);
		}

		// Token: 0x04004186 RID: 16774
		public const string __ObjectPath = "/Script/Engine.CustomDefine";

		// Token: 0x04004187 RID: 16775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004188 RID: 16776
		internal static int __PropertyOffset_DefineName;

		// Token: 0x04004189 RID: 16777
		internal static int __PropertyOffset_DefineValue;
	}
}
