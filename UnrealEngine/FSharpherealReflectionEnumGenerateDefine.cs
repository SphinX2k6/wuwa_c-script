using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200276B RID: 10091
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionEnumGenerateDefine")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSharpherealReflectionEnumGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BAE RID: 154542 RVA: 0x00393296 File Offset: 0x00391496
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionEnumGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionEnumGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionEnumGenerateDefine", ref FSharpherealReflectionEnumGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x17009142 RID: 37186
		// (get) Token: 0x06025BAF RID: 154543 RVA: 0x003932BA File Offset: 0x003914BA
		// (set) Token: 0x06025BB0 RID: 154544 RVA: 0x003932CE File Offset: 0x003914CE
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionEnumGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionEnumGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17009143 RID: 37187
		// (get) Token: 0x06025BB1 RID: 154545 RVA: 0x003932E4 File Offset: 0x003914E4
		// (set) Token: 0x06025BB2 RID: 154546 RVA: 0x00393327 File Offset: 0x00391527
		public TArray<FSharpherealReflectionEnumValueGenerateDefine> EnumDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionEnumValueGenerateDefine> result;
				if ((result = this._EnumDefine) == null)
				{
					result = (this._EnumDefine = new TArray<FSharpherealReflectionEnumValueGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionEnumGenerateDefine.__PropertyOffset_EnumDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumDefine.CopyAssign(value);
			}
		}

		// Token: 0x06025BB3 RID: 154547 RVA: 0x00393335 File Offset: 0x00391535
		public FSharpherealReflectionEnumGenerateDefine()
		{
		}

		// Token: 0x06025BB4 RID: 154548 RVA: 0x0039333D File Offset: 0x0039153D
		public FSharpherealReflectionEnumGenerateDefine(string Name, TArray<FSharpherealReflectionEnumValueGenerateDefine> EnumDefine)
		{
			this.Name = Name;
			this.EnumDefine = EnumDefine;
		}

		// Token: 0x06025BB5 RID: 154549 RVA: 0x00393353 File Offset: 0x00391553
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionEnumGenerateDefine.StaticStruct();
		}

		// Token: 0x06025BB6 RID: 154550 RVA: 0x0039335F File Offset: 0x0039155F
		[NullableContext(2)]
		public FSharpherealReflectionEnumGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BB7 RID: 154551 RVA: 0x00393369 File Offset: 0x00391569
		public FSharpherealReflectionEnumGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BB8 RID: 154552 RVA: 0x00393374 File Offset: 0x00391574
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionEnumGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025BB9 RID: 154553 RVA: 0x0039337E File Offset: 0x0039157E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionEnumGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148A0 RID: 84128
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionEnumGenerateDefine";

		// Token: 0x040148A1 RID: 84129
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148A2 RID: 84130
		internal static int __PropertyOffset_Name;

		// Token: 0x040148A3 RID: 84131
		internal static int __PropertyOffset_EnumDefine;

		// Token: 0x040148A4 RID: 84132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionEnumValueGenerateDefine> _EnumDefine;
	}
}
