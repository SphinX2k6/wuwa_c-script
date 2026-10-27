using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000253 RID: 595
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWaapiJsonManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkWaapiJsonManager : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002317 RID: 8983 RVA: 0x00033F5B File Offset: 0x0003215B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWaapiJsonManager._ClassPtr;
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00033F68 File Offset: 0x00032168
		public UAkWaapiJsonManager() : this(BuiltinUtils.AllocNativeUObject(UAkWaapiJsonManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00033F90 File Offset: 0x00032190
		[NullableContext(1)]
		public UAkWaapiJsonManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWaapiJsonManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00033FC4 File Offset: 0x000321C4
		[NullableContext(1)]
		public unsafe static FAKWaapiJsonObject SetStringField([Nullable(2)] in FAkWaapiFieldNames FieldName, string FieldValue, [Nullable(2)] FAKWaapiJsonObject target)
		{
			FString fstring = FString.AllocTemp(FieldValue);
			FAKWaapiJsonObject result = new FAKWaapiJsonObject(UAkWaapiJsonManager.__SetStringField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, fstring, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0003400D File Offset: 0x0003220D
		[return: Nullable(1)]
		public static FAKWaapiJsonObject SetObjectField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject FieldValue, FAKWaapiJsonObject target)
		{
			return new FAKWaapiJsonObject(UAkWaapiJsonManager.__SetObjectField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (FieldValue ?? new FAKWaapiJsonObject()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00034048 File Offset: 0x00032248
		[return: Nullable(1)]
		public static FAKWaapiJsonObject SetNumberField(in FAkWaapiFieldNames FieldName, float FieldValue, FAKWaapiJsonObject target)
		{
			return new FAKWaapiJsonObject(UAkWaapiJsonManager.__SetNumberField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, FieldValue, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00034075 File Offset: 0x00032275
		[return: Nullable(1)]
		public static FAKWaapiJsonObject SetBoolField(in FAkWaapiFieldNames FieldName, bool FieldValue, FAKWaapiJsonObject target)
		{
			return new FAKWaapiJsonObject(UAkWaapiJsonManager.__SetBoolField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, FieldValue, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000340A2 File Offset: 0x000322A2
		[return: Nullable(1)]
		public static FAKWaapiJsonObject SetArrayStringFields(in FAkWaapiFieldNames FieldName, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> FieldStringValues, FAKWaapiJsonObject target)
		{
			return new FAKWaapiJsonObject(UAkWaapiJsonManager.__SetArrayStringFields_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (FieldStringValues ?? new TArray<string>()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x000340DE File Offset: 0x000322DE
		[return: Nullable(1)]
		public static FAKWaapiJsonObject SetArrayObjectFields(in FAkWaapiFieldNames FieldName, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAKWaapiJsonObject> FieldObjectValues, FAKWaapiJsonObject target)
		{
			return new FAKWaapiJsonObject(UAkWaapiJsonManager.__SetArrayObjectFields_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (FieldObjectValues ?? new TArray<FAKWaapiJsonObject>()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0003411A File Offset: 0x0003231A
		[return: Nullable(1)]
		public static string GetStringField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
		{
			return FString.ToStringAndDeleteNativePtr(UAkWaapiJsonManager.__GetStringField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr));
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00034145 File Offset: 0x00032345
		[return: Nullable(1)]
		public static FAKWaapiJsonObject GetObjectField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
		{
			return new FAKWaapiJsonObject(UAkWaapiJsonManager.__GetObjectField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00034171 File Offset: 0x00032371
		public static float GetNumberField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
		{
			return UAkWaapiJsonManager.__GetNumberField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00034197 File Offset: 0x00032397
		public static int GetIntegerField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
		{
			return UAkWaapiJsonManager.__GetIntegerField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x000341BD File Offset: 0x000323BD
		public static bool GetBoolField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
		{
			return UAkWaapiJsonManager.__GetBoolField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x000341E3 File Offset: 0x000323E3
		[return: Nullable(1)]
		public static TArray<FAKWaapiJsonObject> GetArrayField(in FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
		{
			return new TArray<FAKWaapiJsonObject>(UAkWaapiJsonManager.__GetArrayField_Internal((FieldName ?? new FAkWaapiFieldNames()).NativePtr, (target ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0003420F File Offset: 0x0003240F
		[NullableContext(1)]
		public static FText Conv_FAKWaapiJsonObjectToText([Nullable(2)] FAKWaapiJsonObject INAKWaapiJsonObject)
		{
			return new FText(UAkWaapiJsonManager.__Conv_FAKWaapiJsonObjectToText_Internal((INAKWaapiJsonObject ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0003422B File Offset: 0x0003242B
		[NullableContext(1)]
		public static string Conv_FAKWaapiJsonObjectToString([Nullable(2)] FAKWaapiJsonObject INAKWaapiJsonObject)
		{
			return FString.ToStringAndDeleteNativePtr(UAkWaapiJsonManager.__Conv_FAKWaapiJsonObjectToString_Internal((INAKWaapiJsonObject ?? new FAKWaapiJsonObject()).NativePtr));
		}

		// Token: 0x06002328 RID: 9000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetStringField_Internal(IntPtr FieldName, in FString FieldValue, IntPtr target);

		// Token: 0x06002329 RID: 9001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetObjectField_Internal(IntPtr FieldName, IntPtr FieldValue, IntPtr target);

		// Token: 0x0600232A RID: 9002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetNumberField_Internal(IntPtr FieldName, float FieldValue, IntPtr target);

		// Token: 0x0600232B RID: 9003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetBoolField_Internal(IntPtr FieldName, bool FieldValue, IntPtr target);

		// Token: 0x0600232C RID: 9004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetArrayStringFields_Internal(IntPtr FieldName, IntPtr FieldStringValues, IntPtr target);

		// Token: 0x0600232D RID: 9005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetArrayObjectFields_Internal(IntPtr FieldName, IntPtr FieldObjectValues, IntPtr target);

		// Token: 0x0600232E RID: 9006
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetStringField_Internal(IntPtr FieldName, IntPtr target);

		// Token: 0x0600232F RID: 9007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectField_Internal(IntPtr FieldName, IntPtr target);

		// Token: 0x06002330 RID: 9008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetNumberField_Internal(IntPtr FieldName, IntPtr target);

		// Token: 0x06002331 RID: 9009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIntegerField_Internal(IntPtr FieldName, IntPtr target);

		// Token: 0x06002332 RID: 9010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBoolField_Internal(IntPtr FieldName, IntPtr target);

		// Token: 0x06002333 RID: 9011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetArrayField_Internal(IntPtr FieldName, IntPtr target);

		// Token: 0x06002334 RID: 9012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FAKWaapiJsonObjectToText_Internal(IntPtr INAKWaapiJsonObject);

		// Token: 0x06002335 RID: 9013
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FAKWaapiJsonObjectToString_Internal(IntPtr INAKWaapiJsonObject);

		// Token: 0x06002336 RID: 9014 RVA: 0x00034246 File Offset: 0x00032446
		static UAkWaapiJsonManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWaapiJsonManager");
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00034254 File Offset: 0x00032454
		protected UAkWaapiJsonManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C23 RID: 3107
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWaapiJsonManager";

		// Token: 0x04000C24 RID: 3108
		private static IntPtr _ClassPtr;

		// Token: 0x04000C25 RID: 3109
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
