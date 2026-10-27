using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001056 RID: 4182
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigVariable")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPSOGeneratorConfigVariable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDE8 RID: 60904 RVA: 0x0016119A File Offset: 0x0015F39A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigVariable._ScriptStructPtr != 0) ? FPSOGeneratorConfigVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigVariable", ref FPSOGeneratorConfigVariable._ScriptStructPtr);
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600EDE9 RID: 60905 RVA: 0x001611C0 File Offset: 0x0015F3C0
		// (set) Token: 0x0600EDEA RID: 60906 RVA: 0x00161203 File Offset: 0x0015F403
		public TArray<string> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigVariable.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x0600EDEB RID: 60907 RVA: 0x00161211 File Offset: 0x0015F411
		public FPSOGeneratorConfigVariable()
		{
		}

		// Token: 0x0600EDEC RID: 60908 RVA: 0x00161219 File Offset: 0x0015F419
		public FPSOGeneratorConfigVariable(TArray<string> Values)
		{
			this.Values = Values;
		}

		// Token: 0x0600EDED RID: 60909 RVA: 0x00161228 File Offset: 0x0015F428
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigVariable.StaticStruct();
		}

		// Token: 0x0600EDEE RID: 60910 RVA: 0x00161234 File Offset: 0x0015F434
		[NullableContext(2)]
		public FPSOGeneratorConfigVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDEF RID: 60911 RVA: 0x0016123E File Offset: 0x0015F43E
		public FPSOGeneratorConfigVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDF0 RID: 60912 RVA: 0x00161249 File Offset: 0x0015F449
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigVariable(Pointer, false, true);
		}

		// Token: 0x0600EDF1 RID: 60913 RVA: 0x00161253 File Offset: 0x0015F453
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigVariable(Pointer, MemoryOwner);
		}

		// Token: 0x040080D9 RID: 32985
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigVariable";

		// Token: 0x040080DA RID: 32986
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080DB RID: 32987
		internal static int __PropertyOffset_Values;

		// Token: 0x040080DC RID: 32988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Values;
	}
}
