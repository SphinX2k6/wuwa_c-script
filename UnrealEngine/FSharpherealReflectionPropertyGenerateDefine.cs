using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000815 RID: 2069
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionPropertyGenerateDefine")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSharpherealReflectionPropertyGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B592 RID: 46482 RVA: 0x00120F05 File Offset: 0x0011F105
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionPropertyGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionPropertyGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionPropertyGenerateDefine", ref FSharpherealReflectionPropertyGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x0600B593 RID: 46483 RVA: 0x00120F29 File Offset: 0x0011F129
		// (set) Token: 0x0600B594 RID: 46484 RVA: 0x00120F3D File Offset: 0x0011F13D
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionPropertyGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionPropertyGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600B595 RID: 46485 RVA: 0x00120F54 File Offset: 0x0011F154
		// (set) Token: 0x0600B596 RID: 46486 RVA: 0x00120F97 File Offset: 0x0011F197
		public TArray<FSharpherealReflectionPropertyTypeGenerateDefine> TypeDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionPropertyTypeGenerateDefine> result;
				if ((result = this._TypeDefine) == null)
				{
					result = (this._TypeDefine = new TArray<FSharpherealReflectionPropertyTypeGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionPropertyGenerateDefine.__PropertyOffset_TypeDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TypeDefine.CopyAssign(value);
			}
		}

		// Token: 0x0600B597 RID: 46487 RVA: 0x00120FA5 File Offset: 0x0011F1A5
		public FSharpherealReflectionPropertyGenerateDefine()
		{
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x00120FAD File Offset: 0x0011F1AD
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionPropertyGenerateDefine.StaticStruct();
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x00120FB9 File Offset: 0x0011F1B9
		[NullableContext(2)]
		public FSharpherealReflectionPropertyGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B59A RID: 46490 RVA: 0x00120FC3 File Offset: 0x0011F1C3
		public FSharpherealReflectionPropertyGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B59B RID: 46491 RVA: 0x00120FCE File Offset: 0x0011F1CE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionPropertyGenerateDefine(Pointer, false, true);
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x00120FD8 File Offset: 0x0011F1D8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionPropertyGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040051F4 RID: 20980
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionPropertyGenerateDefine";

		// Token: 0x040051F5 RID: 20981
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040051F6 RID: 20982
		internal static int __PropertyOffset_Name;

		// Token: 0x040051F7 RID: 20983
		internal static int __PropertyOffset_TypeDefine;

		// Token: 0x040051F8 RID: 20984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyTypeGenerateDefine> _TypeDefine;
	}
}
