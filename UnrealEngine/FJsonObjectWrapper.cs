using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015C4 RID: 5572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/JsonUtilities.JsonObjectWrapper")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FJsonObjectWrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014167 RID: 82279 RVA: 0x001D7DEE File Offset: 0x001D5FEE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJsonObjectWrapper._ScriptStructPtr != 0) ? FJsonObjectWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/JsonUtilities.JsonObjectWrapper", ref FJsonObjectWrapper._ScriptStructPtr);
		}

		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x06014168 RID: 82280 RVA: 0x001D7E12 File Offset: 0x001D6012
		// (set) Token: 0x06014169 RID: 82281 RVA: 0x001D7E26 File Offset: 0x001D6026
		public unsafe string JsonString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FJsonObjectWrapper.__PropertyOffset_JsonString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FJsonObjectWrapper.__PropertyOffset_JsonString)), value);
			}
		}

		// Token: 0x0601416A RID: 82282 RVA: 0x001D7E3B File Offset: 0x001D603B
		public FJsonObjectWrapper()
		{
		}

		// Token: 0x0601416B RID: 82283 RVA: 0x001D7E43 File Offset: 0x001D6043
		public FJsonObjectWrapper(string JsonString)
		{
			this.JsonString = JsonString;
		}

		// Token: 0x0601416C RID: 82284 RVA: 0x001D7E52 File Offset: 0x001D6052
		protected override IntPtr GetUStructPtr()
		{
			return FJsonObjectWrapper.StaticStruct();
		}

		// Token: 0x0601416D RID: 82285 RVA: 0x001D7E5E File Offset: 0x001D605E
		[NullableContext(2)]
		public FJsonObjectWrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601416E RID: 82286 RVA: 0x001D7E68 File Offset: 0x001D6068
		public FJsonObjectWrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601416F RID: 82287 RVA: 0x001D7E73 File Offset: 0x001D6073
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJsonObjectWrapper(Pointer, false, true);
		}

		// Token: 0x06014170 RID: 82288 RVA: 0x001D7E7D File Offset: 0x001D607D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJsonObjectWrapper(Pointer, MemoryOwner);
		}

		// Token: 0x0400AEC5 RID: 44741
		public const string __ObjectPath = "/Script/JsonUtilities.JsonObjectWrapper";

		// Token: 0x0400AEC6 RID: 44742
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AEC7 RID: 44743
		internal static int __PropertyOffset_JsonString;
	}
}
