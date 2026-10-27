using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025DD RID: 9693
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptDataInterfaceCompileInfo")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FNiagaraScriptDataInterfaceCompileInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024081 RID: 147585 RVA: 0x0035504F File Offset: 0x0035324F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptDataInterfaceCompileInfo._ScriptStructPtr != 0) ? FNiagaraScriptDataInterfaceCompileInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptDataInterfaceCompileInfo", ref FNiagaraScriptDataInterfaceCompileInfo._ScriptStructPtr);
		}

		// Token: 0x17008AA1 RID: 35489
		// (get) Token: 0x06024082 RID: 147586 RVA: 0x00355073 File Offset: 0x00353273
		// (set) Token: 0x06024083 RID: 147587 RVA: 0x00355087 File Offset: 0x00353287
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008AA2 RID: 35490
		// (get) Token: 0x06024084 RID: 147588 RVA: 0x0035509C File Offset: 0x0035329C
		// (set) Token: 0x06024085 RID: 147589 RVA: 0x003550AC File Offset: 0x003532AC
		public unsafe int UserPtrIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_UserPtrIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_UserPtrIdx) = value;
			}
		}

		// Token: 0x17008AA3 RID: 35491
		// (get) Token: 0x06024086 RID: 147590 RVA: 0x003550C0 File Offset: 0x003532C0
		// (set) Token: 0x06024087 RID: 147591 RVA: 0x00355103 File Offset: 0x00353303
		public FNiagaraTypeDefinition Type
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTypeDefinition result;
				if ((result = this._Type) == null)
				{
					result = (this._Type = new FNiagaraTypeDefinition(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_Type, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTypeDefinition.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_Type, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AA4 RID: 35492
		// (get) Token: 0x06024088 RID: 147592 RVA: 0x00355124 File Offset: 0x00353324
		// (set) Token: 0x06024089 RID: 147593 RVA: 0x00355138 File Offset: 0x00353338
		public unsafe FName RegisteredParameterMapRead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_RegisteredParameterMapRead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_RegisteredParameterMapRead) = value;
			}
		}

		// Token: 0x17008AA5 RID: 35493
		// (get) Token: 0x0602408A RID: 147594 RVA: 0x0035514D File Offset: 0x0035334D
		// (set) Token: 0x0602408B RID: 147595 RVA: 0x00355161 File Offset: 0x00353361
		public unsafe FName RegisteredParameterMapWrite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_RegisteredParameterMapWrite);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_RegisteredParameterMapWrite) = value;
			}
		}

		// Token: 0x17008AA6 RID: 35494
		// (get) Token: 0x0602408C RID: 147596 RVA: 0x00355176 File Offset: 0x00353376
		// (set) Token: 0x0602408D RID: 147597 RVA: 0x00355186 File Offset: 0x00353386
		public unsafe bool bIsPlaceholder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_bIsPlaceholder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceCompileInfo.__PropertyOffset_bIsPlaceholder) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602408E RID: 147598 RVA: 0x00355197 File Offset: 0x00353397
		public FNiagaraScriptDataInterfaceCompileInfo()
		{
		}

		// Token: 0x0602408F RID: 147599 RVA: 0x0035519F File Offset: 0x0035339F
		public FNiagaraScriptDataInterfaceCompileInfo(FName Name, int UserPtrIdx, FNiagaraTypeDefinition Type, TArray<FNiagaraFunctionSignature> RegisteredFunctions, FName RegisteredParameterMapRead, FName RegisteredParameterMapWrite, bool bIsPlaceholder)
		{
			this.Name = Name;
			this.UserPtrIdx = UserPtrIdx;
			this.Type = Type;
			this.RegisteredParameterMapRead = RegisteredParameterMapRead;
			this.RegisteredParameterMapWrite = RegisteredParameterMapWrite;
			this.bIsPlaceholder = bIsPlaceholder;
		}

		// Token: 0x06024090 RID: 147600 RVA: 0x003551D4 File Offset: 0x003533D4
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptDataInterfaceCompileInfo.StaticStruct();
		}

		// Token: 0x06024091 RID: 147601 RVA: 0x003551E0 File Offset: 0x003533E0
		[NullableContext(2)]
		public FNiagaraScriptDataInterfaceCompileInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024092 RID: 147602 RVA: 0x003551EA File Offset: 0x003533EA
		public FNiagaraScriptDataInterfaceCompileInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024093 RID: 147603 RVA: 0x003551F5 File Offset: 0x003533F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptDataInterfaceCompileInfo(Pointer, false, true);
		}

		// Token: 0x06024094 RID: 147604 RVA: 0x003551FF File Offset: 0x003533FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptDataInterfaceCompileInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013535 RID: 79157
		public const string __ObjectPath = "/Script/Niagara.NiagaraScriptDataInterfaceCompileInfo";

		// Token: 0x04013536 RID: 79158
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013537 RID: 79159
		internal static int __PropertyOffset_Name;

		// Token: 0x04013538 RID: 79160
		internal static int __PropertyOffset_UserPtrIdx;

		// Token: 0x04013539 RID: 79161
		internal static int __PropertyOffset_Type;

		// Token: 0x0401353A RID: 79162
		[Nullable(2)]
		private FNiagaraTypeDefinition _Type;

		// Token: 0x0401353B RID: 79163
		internal static int __PropertyOffset_RegisteredParameterMapRead;

		// Token: 0x0401353C RID: 79164
		internal static int __PropertyOffset_RegisteredParameterMapWrite;

		// Token: 0x0401353D RID: 79165
		internal static int __PropertyOffset_bIsPlaceholder;
	}
}
