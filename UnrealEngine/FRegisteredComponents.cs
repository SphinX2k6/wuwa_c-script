using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020FC RID: 8444
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.RegisteredComponents")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRegisteredComponents : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC66 RID: 130150 RVA: 0x002F412E File Offset: 0x002F232E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRegisteredComponents._ScriptStructPtr != 0) ? FRegisteredComponents._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.RegisteredComponents", ref FRegisteredComponents._ScriptStructPtr);
		}

		// Token: 0x17007D04 RID: 32004
		// (get) Token: 0x0601FC67 RID: 130151 RVA: 0x002F4154 File Offset: 0x002F2354
		// (set) Token: 0x0601FC68 RID: 130152 RVA: 0x002F4197 File Offset: 0x002F2397
		public TArray<FComponentRegistryEditorData> RegisteredData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FComponentRegistryEditorData> result;
				if ((result = this._RegisteredData) == null)
				{
					result = (this._RegisteredData = new TArray<FComponentRegistryEditorData>(base.NativePtr + (IntPtr)FRegisteredComponents.__PropertyOffset_RegisteredData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RegisteredData.CopyAssign(value);
			}
		}

		// Token: 0x0601FC69 RID: 130153 RVA: 0x002F41A5 File Offset: 0x002F23A5
		public FRegisteredComponents()
		{
		}

		// Token: 0x0601FC6A RID: 130154 RVA: 0x002F41AD File Offset: 0x002F23AD
		public FRegisteredComponents(TArray<FComponentRegistryEditorData> RegisteredData)
		{
			this.RegisteredData = RegisteredData;
		}

		// Token: 0x0601FC6B RID: 130155 RVA: 0x002F41BC File Offset: 0x002F23BC
		protected override IntPtr GetUStructPtr()
		{
			return FRegisteredComponents.StaticStruct();
		}

		// Token: 0x0601FC6C RID: 130156 RVA: 0x002F41C8 File Offset: 0x002F23C8
		[NullableContext(2)]
		public FRegisteredComponents(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC6D RID: 130157 RVA: 0x002F41D2 File Offset: 0x002F23D2
		public FRegisteredComponents(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC6E RID: 130158 RVA: 0x002F41DD File Offset: 0x002F23DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRegisteredComponents(Pointer, false, true);
		}

		// Token: 0x0601FC6F RID: 130159 RVA: 0x002F41E7 File Offset: 0x002F23E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRegisteredComponents(Pointer, MemoryOwner);
		}

		// Token: 0x04011203 RID: 70147
		public const string __ObjectPath = "/Script/LGUI.RegisteredComponents";

		// Token: 0x04011204 RID: 70148
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011205 RID: 70149
		internal static int __PropertyOffset_RegisteredData;

		// Token: 0x04011206 RID: 70150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FComponentRegistryEditorData> _RegisteredData;
	}
}
