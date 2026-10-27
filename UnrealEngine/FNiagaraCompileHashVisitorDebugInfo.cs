using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002542 RID: 9538
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraCompileHashVisitorDebugInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraCompileHashVisitorDebugInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023666 RID: 144998 RVA: 0x003458ED File Offset: 0x00343AED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraCompileHashVisitorDebugInfo._ScriptStructPtr != 0) ? FNiagaraCompileHashVisitorDebugInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraCompileHashVisitorDebugInfo", ref FNiagaraCompileHashVisitorDebugInfo._ScriptStructPtr);
		}

		// Token: 0x1700880D RID: 34829
		// (get) Token: 0x06023667 RID: 144999 RVA: 0x00345911 File Offset: 0x00343B11
		// (set) Token: 0x06023668 RID: 145000 RVA: 0x00345925 File Offset: 0x00343B25
		public unsafe string Object
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraCompileHashVisitorDebugInfo.__PropertyOffset_Object)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraCompileHashVisitorDebugInfo.__PropertyOffset_Object)), value);
			}
		}

		// Token: 0x1700880E RID: 34830
		// (get) Token: 0x06023669 RID: 145001 RVA: 0x0034593C File Offset: 0x00343B3C
		// (set) Token: 0x0602366A RID: 145002 RVA: 0x0034597F File Offset: 0x00343B7F
		public TArray<string> PropertyKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PropertyKeys) == null)
				{
					result = (this._PropertyKeys = new TArray<string>(base.NativePtr + (IntPtr)FNiagaraCompileHashVisitorDebugInfo.__PropertyOffset_PropertyKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyKeys.CopyAssign(value);
			}
		}

		// Token: 0x1700880F RID: 34831
		// (get) Token: 0x0602366B RID: 145003 RVA: 0x00345990 File Offset: 0x00343B90
		// (set) Token: 0x0602366C RID: 145004 RVA: 0x003459D3 File Offset: 0x00343BD3
		public TArray<string> PropertyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PropertyValues) == null)
				{
					result = (this._PropertyValues = new TArray<string>(base.NativePtr + (IntPtr)FNiagaraCompileHashVisitorDebugInfo.__PropertyOffset_PropertyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyValues.CopyAssign(value);
			}
		}

		// Token: 0x0602366D RID: 145005 RVA: 0x003459E1 File Offset: 0x00343BE1
		public FNiagaraCompileHashVisitorDebugInfo()
		{
		}

		// Token: 0x0602366E RID: 145006 RVA: 0x003459E9 File Offset: 0x00343BE9
		public FNiagaraCompileHashVisitorDebugInfo(string Object, TArray<string> PropertyKeys, TArray<string> PropertyValues)
		{
			this.Object = Object;
			this.PropertyKeys = PropertyKeys;
			this.PropertyValues = PropertyValues;
		}

		// Token: 0x0602366F RID: 145007 RVA: 0x00345A06 File Offset: 0x00343C06
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraCompileHashVisitorDebugInfo.StaticStruct();
		}

		// Token: 0x06023670 RID: 145008 RVA: 0x00345A12 File Offset: 0x00343C12
		[NullableContext(2)]
		public FNiagaraCompileHashVisitorDebugInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023671 RID: 145009 RVA: 0x00345A1C File Offset: 0x00343C1C
		public FNiagaraCompileHashVisitorDebugInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023672 RID: 145010 RVA: 0x00345A27 File Offset: 0x00343C27
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraCompileHashVisitorDebugInfo(Pointer, false, true);
		}

		// Token: 0x06023673 RID: 145011 RVA: 0x00345A31 File Offset: 0x00343C31
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraCompileHashVisitorDebugInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012FF7 RID: 77815
		public const string __ObjectPath = "/Script/Niagara.NiagaraCompileHashVisitorDebugInfo";

		// Token: 0x04012FF8 RID: 77816
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FF9 RID: 77817
		internal static int __PropertyOffset_Object;

		// Token: 0x04012FFA RID: 77818
		internal static int __PropertyOffset_PropertyKeys;

		// Token: 0x04012FFB RID: 77819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PropertyKeys;

		// Token: 0x04012FFC RID: 77820
		internal static int __PropertyOffset_PropertyValues;

		// Token: 0x04012FFD RID: 77821
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PropertyValues;
	}
}
