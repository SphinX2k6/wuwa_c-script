using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001509 RID: 5385
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.OutputActorOwner")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FOutputActorOwner : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013975 RID: 80245 RVA: 0x001CC694 File Offset: 0x001CA894
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOutputActorOwner._ScriptStructPtr != 0) ? FOutputActorOwner._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.OutputActorOwner", ref FOutputActorOwner._ScriptStructPtr);
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x06013976 RID: 80246 RVA: 0x001CC6B8 File Offset: 0x001CA8B8
		// (set) Token: 0x06013977 RID: 80247 RVA: 0x001CC6CC File Offset: 0x001CA8CC
		[Nullable(2)]
		public unsafe AActor OutputActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FOutputActorOwner.__PropertyOffset_OutputActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FOutputActorOwner.__PropertyOffset_OutputActor, value);
			}
		}

		// Token: 0x06013978 RID: 80248 RVA: 0x001CC6E1 File Offset: 0x001CA8E1
		public FOutputActorOwner()
		{
		}

		// Token: 0x06013979 RID: 80249 RVA: 0x001CC6E9 File Offset: 0x001CA8E9
		[NullableContext(1)]
		public FOutputActorOwner(AActor OutputActor)
		{
			this.OutputActor = OutputActor;
		}

		// Token: 0x0601397A RID: 80250 RVA: 0x001CC6F8 File Offset: 0x001CA8F8
		protected override IntPtr GetUStructPtr()
		{
			return FOutputActorOwner.StaticStruct();
		}

		// Token: 0x0601397B RID: 80251 RVA: 0x001CC704 File Offset: 0x001CA904
		[NullableContext(2)]
		public FOutputActorOwner(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601397C RID: 80252 RVA: 0x001CC70E File Offset: 0x001CA90E
		public FOutputActorOwner(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601397D RID: 80253 RVA: 0x001CC719 File Offset: 0x001CA919
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOutputActorOwner(Pointer, false, true);
		}

		// Token: 0x0601397E RID: 80254 RVA: 0x001CC723 File Offset: 0x001CA923
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOutputActorOwner(Pointer, MemoryOwner);
		}

		// Token: 0x0400A94F RID: 43343
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.OutputActorOwner";

		// Token: 0x0400A950 RID: 43344
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A951 RID: 43345
		internal static int __PropertyOffset_OutputActor;
	}
}
