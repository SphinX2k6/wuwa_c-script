using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200276F RID: 10095
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionPropertyGenerateDefine")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSharpherealReflectionPropertyGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BE4 RID: 154596 RVA: 0x003936E6 File Offset: 0x003918E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionPropertyGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionPropertyGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionPropertyGenerateDefine", ref FSharpherealReflectionPropertyGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x1700914D RID: 37197
		// (get) Token: 0x06025BE5 RID: 154597 RVA: 0x0039370A File Offset: 0x0039190A
		// (set) Token: 0x06025BE6 RID: 154598 RVA: 0x0039371E File Offset: 0x0039191E
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

		// Token: 0x1700914E RID: 37198
		// (get) Token: 0x06025BE7 RID: 154599 RVA: 0x00393734 File Offset: 0x00391934
		// (set) Token: 0x06025BE8 RID: 154600 RVA: 0x00393777 File Offset: 0x00391977
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

		// Token: 0x06025BE9 RID: 154601 RVA: 0x00393785 File Offset: 0x00391985
		public FSharpherealReflectionPropertyGenerateDefine()
		{
		}

		// Token: 0x06025BEA RID: 154602 RVA: 0x0039378D File Offset: 0x0039198D
		public FSharpherealReflectionPropertyGenerateDefine(string Name, TArray<FSharpherealReflectionPropertyTypeGenerateDefine> TypeDefine)
		{
			this.Name = Name;
			this.TypeDefine = TypeDefine;
		}

		// Token: 0x06025BEB RID: 154603 RVA: 0x003937A3 File Offset: 0x003919A3
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionPropertyGenerateDefine.StaticStruct();
		}

		// Token: 0x06025BEC RID: 154604 RVA: 0x003937AF File Offset: 0x003919AF
		[NullableContext(2)]
		public FSharpherealReflectionPropertyGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BED RID: 154605 RVA: 0x003937B9 File Offset: 0x003919B9
		public FSharpherealReflectionPropertyGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BEE RID: 154606 RVA: 0x003937C4 File Offset: 0x003919C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionPropertyGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025BEF RID: 154607 RVA: 0x003937CE File Offset: 0x003919CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionPropertyGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148B7 RID: 84151
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionPropertyGenerateDefine";

		// Token: 0x040148B8 RID: 84152
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148B9 RID: 84153
		internal static int __PropertyOffset_Name;

		// Token: 0x040148BA RID: 84154
		internal static int __PropertyOffset_TypeDefine;

		// Token: 0x040148BB RID: 84155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyTypeGenerateDefine> _TypeDefine;
	}
}
