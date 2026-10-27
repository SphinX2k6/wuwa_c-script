using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001048 RID: 4168
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOConverterConfigVariable")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPSOConverterConfigVariable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED26 RID: 60710 RVA: 0x0015FB67 File Offset: 0x0015DD67
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOConverterConfigVariable._ScriptStructPtr != 0) ? FPSOConverterConfigVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOConverterConfigVariable", ref FPSOConverterConfigVariable._ScriptStructPtr);
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600ED27 RID: 60711 RVA: 0x0015FB8B File Offset: 0x0015DD8B
		// (set) Token: 0x0600ED28 RID: 60712 RVA: 0x0015FB9F File Offset: 0x0015DD9F
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigVariable.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigVariable.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600ED29 RID: 60713 RVA: 0x0015FBB4 File Offset: 0x0015DDB4
		// (set) Token: 0x0600ED2A RID: 60714 RVA: 0x0015FBF7 File Offset: 0x0015DDF7
		public TArray<string> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<string>(base.NativePtr + (IntPtr)FPSOConverterConfigVariable.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x0015FC05 File Offset: 0x0015DE05
		public FPSOConverterConfigVariable()
		{
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x0015FC0D File Offset: 0x0015DE0D
		public FPSOConverterConfigVariable(string Name, TArray<string> Values)
		{
			this.Name = Name;
			this.Values = Values;
		}

		// Token: 0x0600ED2D RID: 60717 RVA: 0x0015FC23 File Offset: 0x0015DE23
		protected override IntPtr GetUStructPtr()
		{
			return FPSOConverterConfigVariable.StaticStruct();
		}

		// Token: 0x0600ED2E RID: 60718 RVA: 0x0015FC2F File Offset: 0x0015DE2F
		[NullableContext(2)]
		public FPSOConverterConfigVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x0015FC39 File Offset: 0x0015DE39
		public FPSOConverterConfigVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED30 RID: 60720 RVA: 0x0015FC44 File Offset: 0x0015DE44
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOConverterConfigVariable(Pointer, false, true);
		}

		// Token: 0x0600ED31 RID: 60721 RVA: 0x0015FC4E File Offset: 0x0015DE4E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOConverterConfigVariable(Pointer, MemoryOwner);
		}

		// Token: 0x0400805E RID: 32862
		public const string __ObjectPath = "/Script/Engine.PSOConverterConfigVariable";

		// Token: 0x0400805F RID: 32863
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008060 RID: 32864
		internal static int __PropertyOffset_Name;

		// Token: 0x04008061 RID: 32865
		internal static int __PropertyOffset_Values;

		// Token: 0x04008062 RID: 32866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Values;
	}
}
